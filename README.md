# mystudy
## mystudy loyihasini ishga tushirish uchun qo'llanma.

1. Programm.cs file ga kiring va bu code ni kiriting. Nomlarni kiritishda e'tiborli bo'ling yoki dastur ishlamasligi mumkin.
   ```
   builder.Services.AddDbContext<AppDBContext>(options => options.UseNpgsql(connectionString:"Host=localhost;Database=bu yerga database otini yozing;Username=postgres;Password=passwordni yozing"));
   ```
1. Tools/NuGet Package Manager/Package Manager Console ga kiriladi ``` add-database```  nom kritasiz kiritiladi va ``` update-database``` kiritiladi

