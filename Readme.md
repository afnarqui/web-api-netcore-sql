# dependencias

## Paquetes Nuget
````bash
	
	Microsoft.EntityFrameworkCore.SqlServer
	Microsoft.EntityFrameworkCore.Tools
	Microsoft.AspNetCore.Cors
````

## en la consola
```` bash
	Scaffold-DBContext "Server=localhost;Database=prueba;Trusted_Connection=True;"  Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
	Scaffold-DBContext "Server=localhost;Database=prueba;user=SA;password=quintero1.;"  Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```` 

## agregar los cors

````cs
			---> method ConfigureServices
            services.AddCors(options =>
            {
                options.AddPolicy("permisos",
                    builder =>
                    {
                        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                    }
                    );
            });


			---> method Configure
			app.UseCors("permisos");
````