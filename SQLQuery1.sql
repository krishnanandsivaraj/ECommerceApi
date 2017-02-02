select * from Product_Catalog
SP_HELP Product_Catalog
id = 1, Catagories = "Vehicle", productId = "cars01s", brandName = "Maruti", productName = "Suzuki", subCatagories = "Cars" }
id = 2, Catagories = "Vehicle", productId = "cars02s", brandName = "FIat", productName = "Palio", subCatagories = "Cars" }

Insert into Product_Catalog(CATAGORIES,SUBCATAGORIES,BRANDNAME,PRODUCTID,PRODUCTNAME) values('Vehicle','cars01s','Maruti','Suzuki','Cars'),
('Vehicle','cars02s','Fiat','Palio','Cars');