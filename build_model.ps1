dotnet ef dbcontext scaffold "Server=localhost;Database=HealthVault;UID=sa;password=get@get1" Microsoft.EntityFrameworkCore.SqlServer -f  --use-database-names --project HealthVault.Client -O "HealthVault.Model" -ContextDir "HealthVault.Service"
dotnet build


dotnet ef dbcontext scaffold "Server=localhost;Database=HealthVault;UID=sa;password=get@get1" Microsoft.EntityFrameworkCore.SqlServer -f  --use-database-names --project HealthVault.Client -o "HealthVault.Model" --context-dir "HealthVault.Service"

dotnet ef dbcontext scaffold "Server=localhost;Database=HealthVault;UID=sa;password=get@get1" Microsoft.EntityFrameworkCore.SqlServer -f  --use-database-names --project HealthVault.Client -o "..\HealthVault.Model" -n HealthVault.EF --context-dir "..\HealthVault.Service"

dotnet ef dbcontext scaffold "Server=localhost;Database=HealthVault;UID=sa;password=get@get1" Microsoft.EntityFrameworkCore.SqlServer --namespace "HealthVault.EF" -f  --use-database-names --project HealthVault.Client -o "..\HealthVault.Model" --context-dir "..\HealthVault.Service"


dotnet ef dbcontext scaffold "Server=localhost;Database=HealthVault;UID=sa;password=get@get1" -o "..\HealthVault.Model" Microsoft.EntityFrameworkCore.SqlServer --prefix-output -f  --use-database-names --project HealthVault.Client  --context-dir "..\HealthVault.Service"

