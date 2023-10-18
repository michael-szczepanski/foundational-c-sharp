string permission = "Manager|Admin";
int level = 55;

if (permission.Contains("Admin")) {
  Console.WriteLine($"Welcome, {(level > 55 ? "Super " : "")}Admin user.");
} else if (permission.Contains("Manager") && level >= 20) {
  Console.WriteLine("Contact an Admin for access.");
} else {
  Console.WriteLine("You do not have sufficient privileges.");
}