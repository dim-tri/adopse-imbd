<?php
header('Access-Control-Allow-Origin: *');
header('Access-Control-Allow-Methods: GET');    
header('Content-Type: application/json');

include('simple_html_dom.php');

//$obj = new Scrap_imdb("https://www.imdb.com/chart/top/");
//$obj = new Scrap_imdb("https://www.imdb.com/chart/toptv?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=4da9d9a5-d299-43f2-9c53-f0efa18182cd&pf_rd_r=X2B4R3PPXAFADC0VHMV8&pf_rd_s=right-4&pf_rd_t=15506&pf_rd_i=tvmeter&ref_=chttvm_ql_6");
//$obj -> scrap_data();
//$obj -> JsonReadFile();
//$obj -> scrapActors();

$obj = new Scrap_imdb(null);
$obj->InsertToDB('MoviesAndShows.json');

Class Scrap_imdb{
    private $url;
    private $title;
    private $year;
    private $rank;
    private $photo;
    private $director;
    private $actors;
    private $all_actors = array();
    private $duration;
    private $type;
    private $release;
    private $plot;
    private $big_photo;

    //actor
    private $role_name;
    private $act_small_photo;
    private $actor_link;

    private $actor_name;



    public function __construct($url){
        $this->url = $url;
    }
    


    function scrap_data()
    {
        ini_set('max_execution_time', '900');
        set_time_limit(900);
        $contents =  file_get_html($this->url);
        $num = $contents -> find('tbody[class="lister-list"]',0) -> children();
        $rows = sizeof($num);
        $arr = array();
        $arr['data'] = array();
         for($i=0;$i<$rows;$i++)
            {
                if( ($contents -> find('.titleColumn a',$i) -> plaintext) == null){continue;}
                
                $this->title = $contents -> find('.titleColumn a',$i) -> plaintext;
                $this->year = trim($contents -> find('.titleColumn span',$i) -> plaintext,'()');
                $this->rank = $contents -> find('.ratingColumn strong',$i) -> plaintext;
                $this -> photo = trim($contents -> find('.posterColumn a img',$i) -> src,"");
                $directorAndActors = $contents -> find('.titleColumn a',$i) -> title;
                $directorAndActorsArray = explode(",",$directorAndActors);
                $this->director = $directorAndActorsArray[0];
                $this->actors = $directorAndActorsArray[1] . "," . $directorAndActorsArray[2];;
                $item = $contents -> find('.titleColumn a',$i) -> href;
                $main_link_item = "https://www.imdb.com". $item;
                $this->moreInfo($main_link_item);
              

                $arr_items = array(
                    'id' => $i,
                    'category' => "actors",
                    'title' => $this->title,
                    'year'  => $this->year,
                    'rank' => $this->rank,
                    'small_photo' => $this->photo,
                    'director' => trim($this->director,"(dir.) "),
                    'basic_actors' => $this->actors,
                    'duration' => $this->duration,
                    'type' => $this->type,
                    'release' => $this->release,
                    'plot' => $this->plot,
                    'photo' => $this->big_photo,
                    'all_actors' => $this->all_actors
                   


                );

                array_push($arr['data'],$arr_items);
                $this->all_actors = array();
            }
            //echo json_encode($arr);
            $actors = array();
            //echo sizeof($arr['data'][0]['all_actors']);
            for ($i=0;$i<sizeof($arr['data']);$i++){
                for($j=0;$j<sizeof($arr['data'][0]['all_actors']);$j++){
                    array_push($actors,$arr['data'][$i]['all_actors'][$j]['actor_profile_link']);
                }
              
            }
            
            $this->JsonExportFile($actors,'actors_links');
            
        
    }


 /*   function exportToCsv()
    {
        $fp = fopen('file.csv', 'w');
        fputs($fp, $bom =( chr(0xEF) . chr(0xBB) . chr(0xBF) ));
        foreach ($arr['data'] as $fields)
            {
             fputcsv($fp, $fields);
            }

        fclose($fp);
    }*/


    function scrap_data2(){
        $key = "1090000";
        for ($i=1;$i<=100;$i++)
        {
            $dynamicURI = "https://www.imdb.com/title/tt".(string)$key;
            $contents =  file_get_html($dynamicURI);
            $headers = get_headers($dynamicURI);
            if (strpos($headers[0], '404 Not Found')) {
                (int)$key++;
                continue;
            }else{
                $this->title = $contents -> find('h1',0) -> plaintext;
                echo "\n";
                $pos = strpos($this->title,"&nbsp;");
                $this->title = substr($this->title,0,$pos);
                echo trim($this->title,"&nbsp;");
                (int)$key++;
            }
           
        }

    }


  



    function moreInfo($url){
        $contents =  file_get_html($url);
        $headers = get_headers($url);
        if (strpos($headers[0], '404 Not Found')) {
            echo json_encode("Not found");
           die();
        }else{
                $txt1 = $contents -> find('div .subtext time',0) -> plaintext;
                $this->duration = trim($txt1," ");
                $this->type = $contents -> find('div .subtext a',0) -> plaintext;
                $this->release = trim($contents -> find('div .subtext a',-1) -> plaintext," ");
                $plot =  $contents -> find('.plot_summary',0) ->children(0);
                $this->plot = trim($plot->plaintext," ");
                $act_length = sizeof($contents -> find('.cast_list tr'));
                $this->big_photo = $contents -> find('.poster img',0) -> src;
             
              for($i=1;$i<=$act_length-1;$i++)
                {
                    $act_name = $contents -> find('.cast_list tr',$i) -> find('td',1) -> plaintext;
                    $role_name = $contents -> find('.cast_list tr',$i) -> find('td',3) -> plaintext;
                    $this->role_name = trim($role_name," ");
                   // $act_small_photo = $contents -> find('.cast_list tr',$i) -> find('td .loadlate',0) -> src;
                  //  $this->act_small_photo = trim($act_small_photo," ");
                    $act_lk = $contents -> find('.cast_list tr',$i) -> find('td a',1) -> href;
                    $actor_link = 'https://www.imdb.com' .$act_lk;
              
                    $acts = array(
                        'name' => trim($act_name," "),
                        'movie_role_name' => $this->role_name,
                        'actor_profile_link' => $actor_link
                        
                    );
                    array_push($this->all_actors,$acts);
                }
                
        }

    }


        function JsonExportFile($arr,$name){
            $fp = fopen("$name.json", 'w');
            fwrite($fp, json_encode($arr));
            fclose($fp);
            echo json_encode("Export Complete!");

        }



        function JsonReadFile(){
            $jsonFile1 = json_decode(file_get_contents('movies.json'),true);
            $jsonFile2 = json_decode(file_get_contents('tvShows.json'),true);
            $jsonFile3 = json_decode(file_get_contents('tvShows2.json'),true);
            $jsonFile1 = array_merge($jsonFile1['data'], $jsonFile2['data'],$jsonFile3['data']);
            $test['data'] = $jsonFile1;
            echo json_encode($test);
            $this->JsonExportFile($test,'MoviesAndShows');
    


        }



        function scrapActors(){
            ini_set('max_execution_time', '900');
            set_time_limit(900);
            $links = json_decode(file_get_contents('actors_links.json'));
            $actors = array();
            $actors['data'] = array();
            $filmography = " ";
            for($i=500;$i<800;$i++){
                if($links[$i] == null){
                    continue;
                }else{
                    $contents = file_get_html($links[$i]);
                    $actor_name = trim($contents -> find('h1 span',0) -> plaintext," ");
                    $img = $contents -> find('#name-poster',0) -> src;
                    $bio = trim($contents -> find('#name-bio-text',0) -> plaintext," ");
                    $born = trim($contents -> find('#name-born-info',0) -> plaintext," ");
                    $filmo = $contents -> find('div[class=filmo-category-section]',0) ->children();
                    $rows = sizeof($filmo);
                    for($j=0;$j<$rows;$j++){
                        
                        $filmography .= $filmo[$j] ->find('b',0) -> plaintext . " , " ;
                    }
                   
                    
                    
                    $actors_items = array(
                        'category' => 'actor',
                        'name' => $actor_name,
                        'image' => $img,
                        'bio' => trim($bio,"See full bio &raquo;"),
                        'born' => preg_replace("/\s+/", ' ' ,trim($born,"Born:")),
                        'filmography' => trim($filmography," ")


                    );

                    array_push($actors['data'],$actors_items);
                    $filmography = " ";

                }
            }

            echo json_encode($actors);
            $this->JsonExportFile($actors,'actors5');

        }


        function InsertToDB($NameJsonFile){
            $conn = new mysqli('localhost','root',null,'imdb');
            if($conn -> connect_errno){die();}
            $file = json_decode(file_get_contents("JsonData/$NameJsonFile"),true);
           $dataLength = sizeof($file['data']);
           $m=0;
           $tv=0;
           $other=0;
              for($i=0;$i<$dataLength;$i++){
                if($file['data'][$i]['category'] ==  'movie'){
                   $m++;
                   $name =$file['data'][$i]['title'];
                   $year= $file['data'][$i]['year'];
                   $rank= $file['data'][$i]['rank'];
                   $director =  $file['data'][$i]['director'];
                   $stars = $file['data'][$i]['basic_actors'];
                   $duration = $file['data'][$i]['duration'];
                   $gentre = $file['data'][$i]['type'];
                   $release = $file['data'][$i]['release'];
                   $plot = $file['data'][$i]['plot'];
                   $photo = $file['data'][$i]['photo'];
                   $actors = "";
                   $roles = "";
                   $cat = 1;
                   $all_actors = null;
                   $roles = null;
                   $stmt =  $conn -> prepare("INSERT INTO `movies`(`category_id`,`name`,`year`,`rank`,`director`,`stars`,`duration`,`gentre`,`release`,`plot`,`photo`) VALUES (?,?,?,?,?,?,?,?,?,?,?)");
                   $stmt -> bind_param('isidsssssss',$cat,$name,$year,$rank,$director,$stars,$duration,$gentre,$release,$plot,$photo);
                   $stmt ->execute();
                   $movie_id = $stmt -> insert_id; 
                   $stmt2 = $conn -> prepare("INSERT INTO `actors`(`category_id`,`name`,`role`,`movie_id`) VALUES (?,?,?,?)");
                   $cat_act = 3;
                    for($j=0;$j<sizeof($file['data'][$i]['all_actors']);$j++){
                            $act_name =  $file['data'][$i]['all_actors'][$j]['name'];
                            $act_role = $file['data'][$i]['all_actors'][$j]['movie_role_name'];
                            $stmt2 -> bind_param('issi',$cat_act,$act_name,$act_role,$movie_id);
                            $stmt2 ->execute();
                    }

                }elseif($file['data'][$i]['category'] ==  'tv-show'){
                   $tv++;
                   $name =$file['data'][$i]['title'];
                   $year= $file['data'][$i]['year'];
                   $rank= $file['data'][$i]['rank'];
                   $director =  $file['data'][$i]['director'];
                   $stars = null;
                   $duration = null;
                   $gentre = null;
                   $release = null;
                   $plot = null;
                   $all_actors = null;
                   $roles = null;
                   $photo = $file['data'][$i]['small_photo'];
                   $cat = 2;
                  $stmt =  $conn -> prepare("INSERT INTO `tv-shows`(`category_id`,`name`,`year`,`rank`,`director`,`stars`,`duration`,`gentre`,`release`,`plot`,`photo`) VALUES (?,?,?,?,?,?,?,?,?,?,?)");
                  $stmt -> bind_param('isidsssssss',$cat,$name,$year,$rank,$director,$stars,$duration,$gentre,$release,$plot,$photo);
                  $stmt ->execute();
                  $stmt->close();
                }else{
                   $other++;
                }

           }

          
           

         
        }
















}
?>