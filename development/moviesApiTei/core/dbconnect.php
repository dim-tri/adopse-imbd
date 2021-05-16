<?php
/*$host='localhost';
$db = 'imdb';
$user='root';
$pass='9814';*/

$host='moviesaws.caurajhi4gjd.us-east-2.rds.amazonaws.com';
$db = 'imdb';
$user='admin';
$pass='Stoy22339!';
$port = '3306';


if(gethostname()=='users.iee.ihu.gr') {
	$mysqli = new mysqli($host, $user, $pass, $db,null,'/home/student/it/2014/it144346/mysql/run/mysql.sock');
} else {
        $mysqli = new mysqli($host, $user, $pass, $db);
       //$mysqli($host.':'.$port, $user, $pass,$db);
}

$mysqli -> set_charset("utf8");

if ($mysqli->connect_errno) {
    echo "Failed to connect to MySQL: (" . 
    $mysqli->connect_errno . ") " . $mysqli->connect_error;
}

//$mysqli = new mysqli('moviesaws.caurajhi4gjd.us-east-2.rds.amazonaws.com', 'admin', 'Stoy22339!', 'imdb', '3306');

?>
