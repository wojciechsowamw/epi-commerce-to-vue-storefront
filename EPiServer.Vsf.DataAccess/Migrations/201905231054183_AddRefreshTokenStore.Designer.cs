// <auto-generated />

using System.CodeDom.Compiler;
using System.Data.Entity.Migrations.Infrastructure;
using System.Resources;

namespace EPiServer.Vsf.DataAccess.Migrations
{
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class AddRefreshTokenStore : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddRefreshTokenStore));
        
        string IMigrationMetadata.Id
        {
            get { return "201905231054183_AddRefreshTokenStore"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
