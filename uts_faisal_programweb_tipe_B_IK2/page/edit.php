<div class="alert alert-dark" role="alert" ALIGN="CENTER>
  EDIT BARANG
</div>
<?php	

	    
		
		$id = "";
		$Nama_produk="";
		$Kategori="";
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
  <div class="form-group">
    <label class="control-label col-sm-4">Nama Produk :</label>
    <div class="col-sm-10">
    <input type="text" class="form-control" value="<?php echo $Nama_produk; ?>" placeholder="Nama Produk" name="Nama_produk" >
  </div>
  </div>
  <div class="form-group">
  <label class="control-label col-sm-4">Kategori :</label>
   <div class="col-sm-10">
<select name="Kategori" class="form-control">
<option value="K001">Makanan</option>
<option value="K002">Minuman</option>
<option value="K003">Jajanan Ringan</option>
</select>
</div>
</div>
  
  
   
  
  <div class="form-group">
   <label class="control-label col-sm-2">Harga :</label>
    <div class="col-sm-10">
    <input type="text" class="form-control" value="<?php echo $harga; ?>"  placeholder="harga" name="harga">
  </div>
   </div>
  
    <div class="form-group">
   <label class="control-label col-sm-2">Gambar :</label>
    <div class="col-sm-10">
    <input type="file" class="form-control" name="Foto_produk">
  </div>
   </div>
   
  
   
  
   <button type="submit" class="btn btn-primary">Update</button>
   <button type="reset" class="btn btn-danger">Batal</button>
   
 
</form>