<?php
class Movie {
    private $db;
    private $id;
    private $category_id;
    private $name;
    private $year;
    private $rank;
    private $director;
    private $stars;
    private $duration;
    private $gentre;
    private $realese;
    private $plot;
    private $photo;
    private $created_at;
    private $updated_at;

    public function __construct($db)
    {
        $this->db = $db;
    }
    


    public function getMovie($params,$size=null){
     if(!(array_key_exists('res',$params) || array_key_exists('all',$params) ||  array_key_exists('id',$params) || array_key_exists('m',$params))){
        return false;
     }

     if(array_key_exists('m',$params)){
        if($params['m'] == 'top' && $size === 1){
            return $this->getTop();
        }else if($params['m'] == 'recent' && $size === 1){
            return $this->getRecent();
        }else if($params['m'] == 'comment' && $size === 1){
            if(isset($_GET['uid']) && isset($_GET['mid'])){
                return $this->getComment($_GET['mid'],$_GET['uid']);
            }
        }else if($params['m'] == 'reviews' && $size === 1){
            if(isset($_GET['uid']) && isset($_GET['mid'])){
                return $this->getReviews($_GET['mid'],$_GET['uid']);
            }
        }else if($params['m'] == 'recommend' && $size === 1){
            if(isset($_GET['uid'])){
                return $this->getRecommendations($_GET['uid']);
            }
        }else if($params['m'] == 'wishlist' && $size === 1){
            if(isset($_GET['uid'])){
                return $this->getWishlist($_GET['uid']);
            }
        }else if($params['m'] == 'actor' && $size === 1){
            if(isset($_GET['ad'])){
                return $this->getActor($_GET['ad']);
            }
           
        }else{
            return false;
        }
     }

    
     if(array_key_exists('id',$params)){
        $results = $this->db->prepare('SELECT c.name as cat_name,m.id,m.name,m.year,m.rank,m.director,m.stars,m.duration,m.gentre,m.rank,m.release,m.plot,m.photo
        FROM movies m INNER JOIN categories c ON(m.category_id = c.id) where m.id =  ? ');
        if($params['id'] > 0 && $size === 1){
        $results -> bind_param('i',$params['id']);
        $results->execute();
        return $results->get_result();
        }else return false;
     }


     if(array_key_exists('res',$params) && $size === 1){
        if(!($params['res']>0 && $params['res']<=15)){
            http_response_code('404');
            echo json_encode("Not allowed value to results.");
            die();
        }
       $results = $this->db->prepare('SELECT c.name as cat_name,m.id,m.name,m.year,m.rank,m.director,m.stars,m.duration,m.gentre,m.rank,m.release,m.plot,m.photo
       FROM movies m INNER JOIN categories c ON(m.category_id = c.id) order by year DESC LIMIT ?');
       $results -> bind_param('i',$params['res']);
       $results->execute();
       return $results->get_result();
     }

     if(array_key_exists('all',$params) && $size === 1){
        if(!($params['all'] === 'false' || $params['all']==='true')){
            http_response_code('404');
            echo json_encode("Not allowed.");
            die();
        }
        $results = $this->db->prepare('SELECT c.name as cat_name,m.id,m.name,m.year,m.rank,m.director,m.stars,m.duration,m.gentre,m.rank,m.release,m.plot,m.photo
        FROM movies m INNER JOIN categories c ON(m.category_id = c.id)');
        if($params['all'] == 'true' && $size === 1){
        $results->execute();
        return $results->get_result();
        }else return false;
     }

     if((array_key_exists('all',$params)) && (array_key_exists('sort',$params)) && ($size >= 2 && $size<=3)){
        $all = $params['all'];
        $sort = $params['sort'];
        if($size === 3 && array_key_exists('orderBy',$params)){
            if($all == 'true' && ($sort == 'asc' || $sort == 'desc')){
                $order = $params['orderBy'];
                $results = $this->db->prepare("SELECT c.name as cat_name,m.id,m.name,m.year,m.rank,m.director,m.stars,m.duration,m.gentre,m.rank,m.release,m.plot,m.photo
                FROM movies m INNER JOIN categories c ON(m.category_id = c.id) order by $order $sort");
               // $results -> bind_param('s',$order);
                $results->execute();
                return $results->get_result();
            }

        }
        if($all == 'true' && $sort == 'asc'){
            $results = $this->db->prepare('SELECT c.name as cat_name,m.id,m.name,m.year,m.rank,m.director,m.stars,m.duration,m.gentre,m.rank,m.release,m.plot,m.photo
            FROM movies m INNER JOIN categories c ON(m.category_id = c.id) order by year ASC');
            //$results -> bind_param('s',$sort);
            $results->execute();
            return $results->get_result();
        }elseif($all == 'true' && $sort == 'desc'){
            $results = $this->db->prepare('SELECT c.name as cat_name,m.id,m.name,m.year,m.rank,m.director,m.stars,m.duration,m.gentre,m.rank,m.release,m.plot,m.photo
            FROM movies m INNER JOIN categories c ON(m.category_id = c.id) order by year DESC');
          //  $results -> bind_param('s',$sort);
            $results->execute();
            return $results->get_result();

        }else{
            http_response_code('404');
            echo json_encode("Not allowed.");
            die();
        }
     }else return false;

    }



    public function search($query,$page){
        $temp = array();
        $key1= $query; 
        $key1 = urldecode($key1);
        $key1 = preg_replace('/\s+/', ' ', $key1);
      //  echo $key1;
        $pattern = "/@key/i";
        $key1 = str_replace("@key",$key1,$pattern);
       // echo $key1;
       $results = $this->db->prepare('SELECT c.name as cat_name,m.id,m.name,m.year,m.rank,m.director,m.stars,m.duration,m.gentre,m.rank,m.release,m.plot,m.photo
       FROM movies m INNER JOIN categories c ON(m.category_id = c.id)');
       $results->execute();
       $result = $results->get_result();
       $num = mysqli_num_rows($result);
       if($num > 0){
           $movies_arr = array();
           $movies_arr['data'] = array();
           while($row = $result->fetch_assoc()){
               extract($row);
               $movies_item = array(
                   'type' => $cat_name ,
                   'id' => $id,
                   'name' => $name ,
                   'year' => $year ,
                   'rank' => $rank,
                   'director' => $director ,
                   'stars' => $stars,
                   'duration' => $duration ,
                   'gentre' => $gentre ,
                   'rank' => $rank ,
                   'release' => $release ,
                   'plot' => $plot ,
                   'photo' => $photo
               );
               array_push($movies_arr['data'],$movies_item);
           }
       }
       $movies = $movies_arr['data']; 
      // echo $movies[0]['movie_name'];
     //  echo json_encode(count($movies));
        for($i=0; $i<count($movies);$i++)
        {
            if(preg_match($key1,$movies[$i]['name']) || preg_match($key1,$movies[$i]['name']." ".$movies[$i]['year'] ) )
            {
                array_push($temp,$movies[$i]);
            }

        }
        $temp = $this->pagination2($page,$temp);
       
        return $temp;
    }


    public function pagination($pageNum)
    {
        $results = $this->db->prepare('SELECT c.name as cat_name,m.id,m.name,m.year,m.rank,m.director,m.stars,m.duration,m.gentre,m.rank,m.release,m.plot,m.photo
        FROM movies m INNER JOIN categories c ON(m.category_id = c.id)');
        $results->execute();
        $result = $results->get_result();
        $num = mysqli_num_rows($result);
        if($num > 0){
            $movies_arr = array();
            $movies_arr['data'] = array();
            while($row = $result->fetch_assoc()){
                extract($row);
                $movies_item = array(
                    'type' => $cat_name ,
                    'id' => $id,
                    'name' => $name ,
                    'year' => $year ,
                    'rank' => $rank,
                    'director' => $director ,
                    'stars' => $stars,
                    'duration' => $duration ,
                    'gentre' => $gentre ,
                    'rank' => $rank ,
                    'release' => $release ,
                    'plot' => $plot ,
                    'photo' => $photo
                );
                array_push($movies_arr['data'],$movies_item);
            }
        }
        $movies = $movies_arr['data'];
        $length = $result->num_rows;
        $perPage = 10;
        $startIndex = 0;
        $endIndex = 10;
        $pages = $length / $perPage;
        $pagginatedArr = array();
       // if(!is_int($pages)){$pages = round($pages,0,PHP_ROUND_HALF_UP);}
       //echo json_encode($movies[0]);
       //print_r($movies);
      // die();
        if(!is_int($pages)){$pages = ceil($pages);}
        if($pageNum < 0 || $pageNum >= $pages){
            http_response_code('404');
            echo json_encode("Page Number Out Of Bounds Or No Results Found");
            die();
        }
        for($i=0; $i<$pages; $i++)
        {
            $tempArr = array();
            for($j=$startIndex; $j<$endIndex; $j++)
            {
              try
              {
                  if(!array_key_exists($j,$movies)){
                     break; 
                  }
                array_push($tempArr,$movies[$j]);
              }
              catch(Exception $e)
              {
              
                  break;
                
              }
            }
               
            $pagesNumber = array("Page" => $i , 'Results' => count($tempArr) , 'All_Pages' => $pages-1);
            array_push($tempArr,$pagesNumber);
            array_push($pagginatedArr,$tempArr);
            $startIndex = $endIndex;
            $endIndex = $startIndex + $perPage;

        }
       
        return $pagginatedArr[$pageNum];
    }




    public function pagination2($pageNum,$movies)
    {
    // echo json_encode($movies);
     
        $length = count($movies);
        $perPage = 10;
        $startIndex = 0;
        $endIndex = 10;
        $pages = $length / $perPage;
        $pagginatedArr = array();
       // if(!is_int($pages)){$pages = round($pages,0,PHP_ROUND_HALF_UP);}
       //echo json_encode($movies[0]);
       //print_r($movies);
      // die();
        if(!is_int($pages)){$pages = ceil($pages);}
        if($pageNum < 0 || $pageNum >= $pages){
            http_response_code('404');
            echo json_encode("Page Number Out Of Bounds Or No Results Found");
            die();
        }
       
        for($i=0; $i<$pages; $i++)
        {
            $tempArr = array();
            for($j=$startIndex; $j<$endIndex; $j++)
            {
              try
              {
                  if(!array_key_exists($j,$movies)){
                     break; 
                  }
                array_push($tempArr,$movies[$j]);
              }
              catch(Exception $e)
              {
              
                  break;
                
              }
            }
               
            $pagesNumber = array("Page" => $i , 'Results' => count($tempArr) , 'All_Pages' => $pages-1);
            array_push($tempArr,$pagesNumber);
            array_push($pagginatedArr,$tempArr);
            $startIndex = $endIndex;
            $endIndex = $startIndex + $perPage;

        }
  
        return $pagginatedArr[$pageNum];
    }


    public function getTop()
    {
        $results = $this->db->prepare('select m.* 
        from `movies` m inner join `top-movies` t on (m.id = t.movie_id)');
        $results->execute();
        return $results->get_result();
    }


    public function getRecent()
    {
        $results = $this->db->prepare('select *
        from `movies` 
        order by year desc
        limit 10');
        $results->execute();
        return $results->get_result();
    }

    public function getActor($movieId)
    {
        $results = $this->db->prepare('select a.name
        from actors a inner join movies m on(a.movie_id = m.id) where m.id = ?');
        $results -> bind_param('i',$movieId);
        $results->execute();
        $result =  $results->get_result();
        $movies_arr = array();
        $movies_arr['data'] = array();
        while($row = $result->fetch_assoc()){
            extract($row);
            $movies_item = array(
                'name' => $name 
            );
            array_push($movies_arr['data'],$movies_item);
        }
            echo json_encode($movies_arr['data']);
            die();
    }


    public function getComment($movieId,$userId)
    {
        $results = $this->db->prepare('select c.comment
        from users u inner join comments c on(u.id = c.user_id) inner join movies m on(m.id=c.movie_id) where m.id= ? and u.id= ?');
        $results -> bind_param('ii',$movieId,$userId);
        $results->execute();
        $result =  $results->get_result();
        $movies_arr = array();
        $movies_arr['data'] = array();
        while($row = $result->fetch_assoc()){
            extract($row);
            $movies_item = array(
                'comment' => $comment 
            );
            array_push($movies_arr['data'],$movies_item);
        }
            echo json_encode($movies_arr['data']);
            die();
    }


    public function getReviews($movieId,$userId)
    {
        $results = $this->db->prepare('select r.rank
        from users u inner join users_reviews r on(u.id = r.user_id) inner join movies m on(m.id=r.movie_id) where user_id= ? and movie_id= ?');
        $results -> bind_param('ii',$userId,$movieId);
        $results->execute();
        $result =  $results->get_result();
        $movies_arr = array();
        $movies_arr['data'] = array();
        while($row = $result->fetch_assoc()){
            extract($row);
            $movies_item = array(
                'rank' => $rank 
            );
            array_push($movies_arr['data'],$movies_item);
        }
            echo json_encode($movies_arr['data']);
            die();
    }


    public function getRecommendations($userId)
    {
        $results = $this->db->prepare('select m.*
        from users u inner join wishlistMovie w on(u.id = w.user_id) inner join movies m on(m.id=w.movie_id)  where user_id= ?');
        $results -> bind_param('i',$userId);
        $results->execute();
        $result =  $results->get_result();
        $num_results = mysqli_num_rows($result);
        $movies_arr = array();
        $movies_arr['data'] = array();

        if($num_results > 0){
           while($row = $result->fetch_assoc()){
            extract($row);
            $movies_item = array(
                'rank' => $rank,
                'gentre' => $gentre,
                'id' => $id
            );
            array_push($movies_arr['data'],$movies_item);
            }

            $gentre_arr = array();
            $gentre_all = array();
            $rank_arr = array();
            $movies_id = array();
            
            for($i=0;$i<count($movies_arr['data']);$i++){
                $gentre_explode = explode(',',trim($movies_arr['data'][$i]['gentre']));
                array_push($gentre_arr,$gentre_explode);
                array_push($gentre_all,$movies_arr['data'][$i]['gentre']);
                array_push($rank_arr,$movies_arr['data'][$i]['rank']);
                array_push($movies_id,$movies_arr['data'][$i]['id']);
            }
            $fullIds = null;
            for($i=0;$i<count($movies_arr['data']);$i++){
                $ids = "m.id <> " . "'".$movies_id[$i]."'";
                $and = 'and';
                $fullIds .= $ids . ' '. $and . ' ';

            }
                $fullIds = rtrim($fullIds,"and ");
         

            $average_rank = (ceil(array_sum($rank_arr) / count($movies_arr['data']))) - 2;
            $gentre_all = array_unique($gentre_all);
            $full = null;
            for($i=0;$i<count($gentre_all);$i++){
                if(!array_key_exists($i,$gentre_all)){
                    break; 
                 }
                $sqlString = "gentre = " . "'".$gentre_all[$i]."'";
                $or = 'or';
                $full .= $sqlString . ' '. $or . ' ';
            }

            $full= rtrim($full,"or ");

            $results = $this->db->prepare("select *
            from movies m 
            where m.rank >= $average_rank  and ($full) and ($fullIds) order by year desc limit 10");
           
        
            $results->execute();
            $result =  $results->get_result();

            $movies_arr = array();
            $movies_arr['data'] = array();
            while($row = $result->fetch_assoc()){
                extract($row);
                $movies_item = array(
                    'type' => $cat_name ?? null ,
                    'id' => $id,
                    'name' => $name ,
                    'year' => $year ,
                    'rank' => $rank,
                    'director' => $director ,
                    'stars' => $stars,
                    'duration' => $duration ,
                    'gentre' => $gentre ,
                    'rank' => $rank ,
                    'release' => $release ,
                    'plot' => $plot ,
                    'photo' => $photo
                );
                array_push($movies_arr['data'],$movies_item);
            }

            echo json_encode($movies_arr['data']);
     
        die();


        }else{
            $arr = array("Message" => 'No Reccomendations , add something to wishlist','Error' => true);
            echo json_encode($arr);
        }

        die();


    }



    public function getWishlist($userId)
    {
        $results = $this->db->prepare('select movies.*
        from `users` inner join `wishlistMovie` on(users.id = wishlistMovie.user_id) inner join `movies` on(movies.id = wishlistMovie.movie_id)  where wishlistMovie.user_id= ?');
        $results -> bind_param('s',$userId);
      
        $results->execute();
        $result =  $results->get_result();
        $movies_arr = array();
        $movies_arr['data'] = array();
        while($row = $result->fetch_assoc()){
            extract($row);
            $movies_item = array(
                'type' => $cat_name ?? null,
                'id' => $id,
                'name' => $name ,
                'year' => $year ,
                'rank' => $rank,
                'director' => $director ,
                'stars' => $stars,
                'duration' => $duration ,
                'gentre' => $gentre ,
                'rank' => $rank ,
                'release' => $release ,
                'plot' => $plot ,
                'photo' => $photo
            );
            array_push($movies_arr['data'],$movies_item);
        }
            echo json_encode($movies_arr['data']);
            die();
    }

}
?>