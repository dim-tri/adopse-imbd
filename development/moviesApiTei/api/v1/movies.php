<?php
header('Access-Control-Allow-Origin: *');
header('Access-Control-Allow-Methods: GET');    
header('Content-Type: application/json');

include_once('../../core/initialize.php');

if($_SERVER['REQUEST_METHOD'] === 'GET'){
     $getURI = parse_url($_SERVER['REQUEST_URI']);
     if(!isset($getURI['query'])){
        http_response_code('404');
        echo json_encode("No params set up.");
        die();}
    $params = array();

    if(isset($_GET['page'])){
        $page = filter_var($_GET['page'],FILTER_SANITIZE_STRING);
        $params += ['page' => (int)$page];
        $obj = new Movie($mysqli);
        echo json_encode($obj->pagination($params['page']));
        die();
    } 

if(!isset($_GET['s'])){

    if(isset($_GET['m'])){
        $m = filter_var($_GET['m'],FILTER_SANITIZE_STRING);
        $params += ['m' => (string)$m];
    } 
    
    if(isset($_GET['id'])){
        $id = filter_var($_GET['id'],FILTER_SANITIZE_STRING);
        $params += ['id' => (int)$id];
    } 
    
    if(isset($_GET['name'])){
        $name = filter_var($_GET['name'],FILTER_SANITIZE_STRING);
       $params += ['name'=>$name];
    } 
     
    if(isset($_GET['res'])){
        $res = filter_var($_GET['res'],FILTER_SANITIZE_STRING);
        $params += ['res'=>(int)$res];
    }
     
    if(isset($_GET['sort'])){
        $sort = filter_var($_GET['sort'],FILTER_SANITIZE_STRING);
        $params += ['sort'=>$sort];
    }
     
    if(isset($_GET['all'])){
        $all = filter_var($_GET['all'],FILTER_SANITIZE_STRING);
        $params += ['all'=>$all];
    }

    if(isset($_GET['o'])){
        $o = filter_var($_GET['o'],FILTER_SANITIZE_STRING);
        $params += ['orderBy'=>$o];
    }
      
    $obj = new Movie($mysqli);
    if($obj -> getMovie($params,sizeof($params)) === false){
        http_response_code('404');
        echo json_encode("No right or no params set up.");
        die();
    }else{
        $result = $obj -> getMovie($params,sizeof($params));
        $num = mysqli_num_rows($result);
        if($num > 0){
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
        }else{
            http_response_code('404');
            echo json_encode("No results returned.");
            die();
        }

    }

}else{
    if(isset($_GET['s']) && isset($_GET['pnum'])){
        $s = filter_var($_GET['s'],FILTER_SANITIZE_STRING);
        $params = ['search'=>$s];
        $obj = new Movie($mysqli);
        $res = $obj -> search($s,$_GET['pnum']);
        echo json_encode($res);
    }else{
        http_response_code('404');
        echo json_encode("Error check params.");
        die();
    }
}


}else{
    http_response_code('404');
    echo json_encode("Wrong request method.");
    die();
}




















?>