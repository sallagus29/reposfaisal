<?php

$db_host = "localhost";
$db_user = "root";
$db_pwd = "";
$db_name = "dbproduk";

mysql_connect($db_host,$db_user,$db_pwd);
mysql_select_db($db_name);

function getAutoId($fields, $table, $inisial)
{
	$leng_inisial = strlen($inisial);
	$query		  = mysql_query('SELECT MAX('.
					$fields.') as max from '.
					$table);
					
	$result		  = mysql_fetch_array($query);
	$number 	  = 0;
	$imax		  = 10;
	$tmp 		  = "";
	
	if ($result['max'] !='') {
		$number = substr($result['max'],
		strlen($inisial));
		
	}
	$number ++;
	$number = strval($number);
for ($i=1; $i<=($imax-strlen($inisial)-strlen($number)); $i++){
		 $tmp=$tmp."0";
}

return $inisial.$tmp.$number;
}