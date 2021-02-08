using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Esmeraldaplus.Infrastructure;
using Esmeraldaplus.Core.Domain;

namespace Esmeraldaplus.Infrastructure.Data
{
    public partial class EsmeraldaplusDbContext : DbContext
    {
        public EsmeraldaplusDbContext()
        {
        }

        public EsmeraldaplusDbContext(DbContextOptions<EsmeraldaplusDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aspnetroleclaims> Aspnetroleclaims { get; set; }
        public virtual DbSet<Aspnetroles> Aspnetroles { get; set; }
        public virtual DbSet<Aspnetuserclaims> Aspnetuserclaims { get; set; }
        public virtual DbSet<Aspnetuserlogins> Aspnetuserlogins { get; set; }
        public virtual DbSet<Aspnetuserroles> Aspnetuserroles { get; set; }
        public virtual DbSet<Aspnetusers> Aspnetusers { get; set; }
        public virtual DbSet<Aspnetusertokens> Aspnetusertokens { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }
        public virtual DbSet<EstadoDePedido> EstadoDePedido { get; set; }
        public virtual DbSet<IdentityuserString> IdentityuserString { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<OrdenDeCompra> OrdenDeCompra { get; set; }
        public virtual DbSet<OrdenDeVenta> OrdenDeVenta { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Telefono> Telefono { get; set; }
        public virtual DbSet<TipoDeProducto> TipoDeProducto { get; set; }
        public virtual DbSet<TipoDeTelefono> TipoDeTelefono { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseMySQL("database=esmeralda_plus;server=localhost;port=3306;user id=root;password=root");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aspnetroleclaims>(entity =>
            {
                entity.ToTable("aspnetroleclaims");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(127);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetroleclaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
            });

            modelBuilder.Entity<Aspnetroles>(entity =>
            {
                entity.ToTable("aspnetroles");

                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(127);

                entity.Property(e => e.ConcurrencyStamp).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<Aspnetuserclaims>(entity =>
            {
                entity.ToTable("aspnetuserclaims");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserclaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserlogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PRIMARY");

                entity.ToTable("aspnetuserlogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(127);

                entity.Property(e => e.ProviderKey).HasMaxLength(127);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserlogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserroles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PRIMARY");

                entity.ToTable("aspnetuserroles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetUserRoles_RoleId");

                entity.Property(e => e.UserId).HasMaxLength(127);

                entity.Property(e => e.RoleId).HasMaxLength(127);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetusers>(entity =>
            {
                entity.ToTable("aspnetusers");

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Aspnetusertokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PRIMARY");

                entity.ToTable("aspnetusertokens");

                entity.Property(e => e.UserId).HasMaxLength(127);

                entity.Property(e => e.LoginProvider).HasMaxLength(127);

                entity.Property(e => e.Name).HasMaxLength(127);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetusertokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<EstadoDePedido>(entity =>
            {
                entity.HasKey(e => e.IdEstadoPedido)
                    .HasName("PRIMARY");

                entity.ToTable("estado_de_pedido");

                entity.Property(e => e.IdEstadoPedido).HasColumnName("id_estado_pedido");

                entity.Property(e => e.NombreEstadoPedido)
                    .HasColumnName("nombre_estado_pedido")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<IdentityuserString>(entity =>
            {
                entity.ToTable("identityuser<string>");

                entity.Property(e => e.Id).HasMaxLength(127);
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => e.IdInventario)
                    .HasName("PRIMARY");

                entity.ToTable("inventario");

                entity.HasIndex(e => e.IdOrdenCompra)
                    .HasName("id_orden_compra");

                entity.HasIndex(e => e.IdOrdenVenta)
                    .HasName("id_orden_venta");

                entity.HasIndex(e => e.IdPedido)
                    .HasName("id_pedido");

                entity.HasIndex(e => e.IdProducto)
                    .HasName("id_producto");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("id_usuario");

                entity.Property(e => e.IdInventario).HasColumnName("id_inventario");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.IdOrdenCompra).HasColumnName("id_orden_compra");

                entity.Property(e => e.IdOrdenVenta).HasColumnName("id_orden_venta");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("id_usuario")
                    .HasMaxLength(10);

                entity.HasOne(d => d.IdOrdenCompraNavigation)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.IdOrdenCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inventario_ibfk_2");

                entity.HasOne(d => d.IdOrdenVentaNavigation)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.IdOrdenVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inventario_ibfk_3");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inventario_ibfk_4");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("inventario_ibfk_5");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("inventario_ibfk_1");
            });

            modelBuilder.Entity<OrdenDeCompra>(entity =>
            {
                entity.HasKey(e => e.IdOrdenCompra)
                    .HasName("PRIMARY");

                entity.ToTable("orden_de_compra");

                entity.Property(e => e.IdOrdenCompra).HasColumnName("id_orden_compra");

                entity.Property(e => e.NombreProveedor)
                    .HasColumnName("nombre_proveedor")
                    .HasMaxLength(15);

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasColumnName("producto")
                    .HasMaxLength(30);

                entity.Property(e => e.ValorTotalProducto).HasColumnName("valor_total_producto");

                entity.Property(e => e.ValorUnitarioProducto).HasColumnName("valor_unitario_producto");
            });

            modelBuilder.Entity<OrdenDeVenta>(entity =>
            {
                entity.HasKey(e => e.IdOrdenVenta)
                    .HasName("PRIMARY");

                entity.ToTable("orden_de_venta");

                entity.Property(e => e.IdOrdenVenta).HasColumnName("id_orden_venta");

                entity.Property(e => e.CantidadProducto).HasColumnName("cantidad_producto");

                entity.Property(e => e.ValorTotal).HasColumnName("valor_total");

                entity.Property(e => e.ValorUnitario).HasColumnName("valor_unitario");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PRIMARY");

                entity.ToTable("pedido");

                entity.HasIndex(e => e.IdEstadoPedido)
                    .HasName("id_estado_pedido");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("id_usuario");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.IdEstadoPedido).HasColumnName("id_estado_pedido");

                entity.Property(e => e.IdUsuario)
                    .IsRequired()
                    .HasColumnName("id_usuario")
                    .HasMaxLength(10);

                entity.HasOne(d => d.IdEstadoPedidoNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.IdEstadoPedido)
                    .HasConstraintName("pedido_ibfk_1");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pedido_ibfk_2");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PRIMARY");

                entity.ToTable("producto");

                entity.HasIndex(e => e.IdTipoProducto)
                    .HasName("id_tipo_producto");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.CantidaadProducto).HasColumnName("cantidaad_producto");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(30);

                entity.Property(e => e.IdTipoProducto).HasColumnName("id_tipo_producto");

                entity.Property(e => e.PrecioProducto).HasColumnName("precio_producto");

                entity.HasOne(d => d.IdTipoProductoNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdTipoProducto)
                    .HasConstraintName("producto_ibfk_1");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PRIMARY");

                entity.ToTable("rol");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.TipoDeRol)
                    .HasColumnName("tipo_de_rol")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Telefono>(entity =>
            {
                entity.HasKey(e => e.IdTelefono)
                    .HasName("PRIMARY");

                entity.ToTable("telefono");

                entity.HasIndex(e => e.IdTipoTelefono)
                    .HasName("id_tipo_telefono");

                entity.Property(e => e.IdTelefono).HasColumnName("id_telefono");

                entity.Property(e => e.IdTipoTelefono).HasColumnName("id_tipo_telefono");

                entity.Property(e => e.NumeroTelefonico)
                    .IsRequired()
                    .HasColumnName("numero_telefonico")
                    .HasMaxLength(11);

                entity.HasOne(d => d.IdTipoTelefonoNavigation)
                    .WithMany(p => p.Telefono)
                    .HasForeignKey(d => d.IdTipoTelefono)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("telefono_ibfk_1");
            });

            modelBuilder.Entity<TipoDeProducto>(entity =>
            {
                entity.HasKey(e => e.IdTipoProducto)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_de_producto");

                entity.Property(e => e.IdTipoProducto).HasColumnName("id_tipo_producto");

                entity.Property(e => e.NombreProducto)
                    .HasColumnName("nombre_producto")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TipoDeTelefono>(entity =>
            {
                entity.HasKey(e => e.IdTipoTelefono)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_de_telefono");

                entity.Property(e => e.IdTipoTelefono).HasColumnName("id_tipo_telefono");

                entity.Property(e => e.TipoDeTelefono1)
                    .HasColumnName("tipo_de_telefono")
                    .HasMaxLength(7);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.IdRol)
                    .HasName("id_rol");

                entity.HasIndex(e => e.IdTelefono)
                    .HasName("id_telefono");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasMaxLength(10);

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasMaxLength(15);

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.IdTelefono).HasColumnName("id_telefono");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(15);

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuarios_ibfk_1");

                entity.HasOne(d => d.IdTelefonoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTelefono)
                    .HasConstraintName("usuarios_ibfk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
