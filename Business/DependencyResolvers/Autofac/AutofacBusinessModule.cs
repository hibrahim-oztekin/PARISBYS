using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DernekManager>().As<IDernekService>().SingleInstance();
            builder.RegisterType<EfDernekDal>().As<IDernekDal>().SingleInstance();

            builder.RegisterType<SehirManager>().As<ISehirService>().SingleInstance();
            builder.RegisterType<EfSehirDal>().As<ISehirDal>().SingleInstance();


            builder.RegisterType<KurulusKanunManager>().As<IKurulusKanunService>().SingleInstance();
            builder.RegisterType<EfKurulusKanunDal>().As<IKurulusKanunDal>().SingleInstance();


            builder.RegisterType<CrcmUyelikFormDurumManager>().As<ICrcmUyelikFormDurumService>().SingleInstance();
            builder.RegisterType<EfCrcmUyelikFormDurumDal>().As<ICrcmUyelikFormDurumDal>().SingleInstance();


            builder.RegisterType<BkBolgeManager>().As<IBkBolgeService>().SingleInstance();
            builder.RegisterType<EfBkBolgeDal>().As<IBkBolgeDal>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
