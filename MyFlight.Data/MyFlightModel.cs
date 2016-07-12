using System;

namespace MyFlight.Data
{
    using System.Data.Entity;
    using System.Linq;

    public class MyFlightModel : DbContext, IDisposable
    {
        // Der Kontext wurde für die Verwendung einer MyFlightModel-Verbindungszeichenfolge aus der 
        // Konfigurationsdatei ('App.config' oder 'Web.config') der Anwendung konfiguriert. Diese Verbindungszeichenfolge hat standardmäßig die 
        // Datenbank 'MyFlight.Data.MyFlightModel' auf der LocalDb-Instanz als Ziel. 
        // 
        // Wenn Sie eine andere Datenbank und/oder einen anderen Anbieter als Ziel verwenden möchten, ändern Sie die MyFlightModel-Zeichenfolge 
        // in der Anwendungskonfigurationsdatei.
        public MyFlightModel()
            : base("name=MyFlightModel")
        {
        }

        // Fügen Sie ein 'DbSet' für jeden Entitätstyp hinzu, den Sie in das Modell einschließen möchten. Weitere Informationen 
        // zum Konfigurieren und Verwenden eines Code First-Modells finden Sie unter 'http://go.microsoft.com/fwlink/?LinkId=390109'.

        public virtual DbSet<Player> Players { get; set; }
        
        public virtual DbSet<Bag> Bags { get; set; }

        public virtual DbSet<Club> Clubs { get; set; }

        public virtual DbSet<Ball> Balls { get; set; }
    }
}