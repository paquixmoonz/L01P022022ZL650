using Microsoft.EntityFrameworkCore;
using L01P022022ZL650.Models;
namespace L01P022022ZL650.Models

{
	public class notas_context:DbContext
	{
		public notas_context(DbContextOptions options) : base(options)
		{
		}
		//public DbSet<alumnos> alumnos { get; set; }
	    public DbSet<L01P022022ZL650.Models.alumnos> alumnos { get; set; } = default!;
	    public DbSet<L01P022022ZL650.Models.facultades> facultades { get; set; } = default!;
	    public DbSet<L01P022022ZL650.Models.materias> materias { get; set; } = default!;
	    public DbSet<L01P022022ZL650.Models.departamentos> departamentos { get; set; } = default!;
	}
}
