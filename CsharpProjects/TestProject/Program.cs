string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin")) {
  Console.WriteLine($"Welcome, {(level > 55 ? "Super " : "")}Admin user.");
}