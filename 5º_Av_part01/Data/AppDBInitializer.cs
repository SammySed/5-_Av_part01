using _5º_Av_part01.Models;

namespace _5º_Av_part01.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                //Criar tarefas
                if (!context.Clientes.Any())
                {
                    context.Clientes.AddRange(new List<Cliente>()
                    {
                        new Cliente()
                        {
                            Name = "Samuel Vieira"
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

    }
}
