using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 有关程序集的常规信息通过下列属性集
// 控制。更改这些属性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("报工扫描")]
[assembly: AssemblyDescription("隆丰制鞋事业部报工扫描PDA程序")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("HENAN PROSPER INC.")]
[assembly: AssemblyProduct("报工扫描")]
[assembly: AssemblyCopyright("Copyright HENAN PROSPER INC©  2020")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// 将 ComVisible 设置为 false 使此程序集中的类型
// 对 COM 组件不可见。如果需要从 COM 访问此程序集中的类型，
// 则将该类型上的 ComVisible 属性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("5647433d-5ee5-4e12-8a9d-c692177e21f8")]

// 程序集的版本信息由下面四个值组成:
//
//      主版本
//      次版本
//      内部版本号
//      修订号
//
[assembly: AssemblyVersion("2020.08.14.25")]

// 以下属性会取消显示 FxCop 警告“CA2232 : Microsoft.Usage : 向程序集添加 STAThreadAttribute 属性”，
// 因为设备应用程序不支持 STA 线程。
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2232:MarkWindowsFormsEntryPointsWithStaThread")]
