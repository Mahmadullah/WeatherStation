<?php
	$city = $_GET['city'];
	if($city=="london"){
		$sResponse = file_get_contents("http://api.openweathermap.org/data/2.5/find?q=London,uk&units=metric");
		header('Content-Type: application/json');
		echo $sResponse;
	}
	else if($city=="barcelona"){
		$sResponse = file_get_contents("http://188.166.34.53:2222/");
		header('Content-Type: application/json');
		echo $sResponse;
	}
	else if($city=="copenhagen"){
		$sResponse = file_get_contents("http://188.166.34.53:1339/");
		$sResponse = urldecode($sResponse);
		header('Content-Type: application/json');
		echo $sResponse;
	}
	else if($city=="berlin"){
		$sResponse = file_get_contents("http://188.166.34.53:1111/");
		header('Content-Type: application/json');
		echo $sResponse;
	}
?>