using ChargeMap.Models;
using PlanejadorViagens.Models;

public class UsuarioRepository : IRepository<Usuario>
{
    private readonly AppDbContext _context;

    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Usuario> GetAll() => _context.Usuarios.ToList();

    public Usuario GetById(int id) => _context.Usuarios.Find(id);

    public void Add(Usuario entity)
    {
        _context.Usuarios.Add(entity);
        _context.SaveChanges();
    }

    public void Update(Usuario entity)
    {
        _context.Usuarios.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _context.Usuarios.Find(id);
        if (entity != null)
        {
            _context.Usuarios.Remove(entity);
            _context.SaveChanges();
        }
    }
}
