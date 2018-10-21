<div class="alert alert-warning" role="alert" ALIGN="CENTER">
  MASUKAN DATA ANDA
</div>
<?php	

	    
		
		$id = "";
		$Nama_produk="";
		$Kategori_id="";
		$harga="";
		$action ="proses/produk_add.php";
		if(isset($_GET['id'])) {
			$id = $_GET['id'];
		include"Koneksi.php";
		$query = "select * from produk where Kode_produk ='".$id."'";
		$row = mysql_query($query);
		$res = mysql_fetch_array($row);
		$Nama_produk = $res['Nama_produk'];
		$Kategori= $res['Kategori_id'];
		$harga= $res['harga'];
		$action ="proses/produk_update.php";
		
		}

?>

<form class="from-horizontal" method= "POST" action="<?php echo $action; ?>" enctype="multipart/form-data">
<input type="hidden" value="<?php echo $id; ?>" name="id">
  <div class="form-group align-items-center">
    <label class="control-label col-sm-4">Nama Produk :</label>
    <div class="col-sm-7">
    <input type="text" class="form-control" value="<?php echo $Nama_produk; ?>" placeholder="Nama Produk" name="Nama_produk" >
  </div>
  </div>
  
  <div class="form-row">
      <div class="col-auto my-2">
      <label class="control-label col-sm-5">Kategori :</label>
      <select class="custom-select mr-sm-5" id="inlineFormCustomSelect">
			<?php
			include"Koneksi.php";
			$query = "select * from kategori";
			$hasil = mysql_query($query);
			while ($qtabel = mysql_fetch_assoc($hasil))
			{
				echo '<option value="'.$qtabel['Kategori_id'].'">'.$qtabel['Kategori_desc'].'</option>';				
			}
			?>
		</select>
  </div>
   </div> 
  
  <div class="form-group">
   <label class="control-label col-sm-2">Harga :</label>
    <div class="col-sm-7">
    <input type="text" class="form-control" value="<?php echo $harga; ?>"  placeholder="harga" name="harga">
  </div>
   </div>
  
    <div class="form-group">
   <label class="control-label col-sm-2">Gambar :</label>
    <div class="col-sm-7">
    <input type="file" class="form-control" name="Fotoproduk">
	<small id="passwordHelpBlock" class="form-text text-muted">
  silahkan pilih gambar yang anda sukai klo yang tidak suka jangan di pilih !!!
</small>
  </div>
   </div>
   
  
  <button type="button" class="btn btn-outline-secondary">SIMPAN</button>
   <button type="button" class="btn btn-outline-primary">BATAL</button>
</form>