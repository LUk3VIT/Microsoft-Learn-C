string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin")){
    string validacaoLevel = level > 55 ? "Welcome, Super Admin user." : level <= 55 ? "Welcome, Admin user." : level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.";
} else {
    string validacaoPermission = "You do not have sufficient privileges.";
}

Console.WriteLine($"{validacaoLevel} {validacaoPermission}");