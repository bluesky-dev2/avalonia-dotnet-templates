namespace AvaloniaAppTemplate

open System
open Avalonia.Controls
open Avalonia.Controls.Templates
open AvaloniaAppTemplate.ViewModels

type ViewLocator() =
    interface IDataTemplate with
        
        member _.Build(data) =
            let name = data.GetType().FullName.Replace("ViewModel", "View")
            let typ = Type.GetType(name)
            if isNull typ then
                upcast TextBlock(Text = sprintf "Not Found: %s" name)
            else
                downcast Activator.CreateInstance(typ)

        member _.Match(data) = data :? ViewModelBase
