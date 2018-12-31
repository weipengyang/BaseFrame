整个项目遵循MVP模式的设计架构，项目的具体结构以下会进行详述。在开发过程中，请遵循此文档的说明，来存放实现了对应功能的文件。

1、BaseMvpInfrastructure文件夹：属于MVP模式的基础实现，一般不用更改，此文件夹中按照Model、View、Presenter对不同文件进行细分整理。

2、Configuration文件夹：存放了autofac依赖注入的配置文件，当添加了新的View和Presenter功能实现后，需要在autofac.config中配置接口和具体实现类的映射。

3、Examples文件夹：存放项目不同功能实现的样例代码。

4、FrameInterface文件夹：存放自定义的View接口和Presenter接口文件；1）自定义的View接口，存放到ViewInterface文件夹下；2）自定义的Presenter接口，存放到PresenterInterface文件夹下。

5、Model文件夹：存放自定义的Model类。

6、Presenter文件夹：存放自定义的Presenter接口实现类。

7、Service文件夹：存放自定义可重用的Service服务实现类。

8、View文件夹：存放自定义的View接口实现类；在此文件夹下，按功能划分了CommonView、MultiDocView、SingleDocView三个子文件夹；1）CommonView文件夹存放自定义、可重用的控件；2）MultiDocView文件夹，存放多文档View实现类；3）SingleDocView文件夹，存放单文档View实现类。

9、指定程序的主窗体：通过将窗体对象实现IMainView接口，表示此窗体即为应用程序的主窗体；程序启动时，会通过依赖注入容器获取到IMainView接口的实现窗体，将此接口转换为Form对象后，再交由Application.Run方法来启动整个应用程序。

