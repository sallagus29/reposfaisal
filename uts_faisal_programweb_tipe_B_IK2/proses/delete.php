<?php
include"Koneksi.php";

$id = $_GET['id'];
$query = "DELETE FROM produk WHERE Kode_produk ='$id'";
		mysql_query($query);
		
		header("location:../index.php?mod=list");