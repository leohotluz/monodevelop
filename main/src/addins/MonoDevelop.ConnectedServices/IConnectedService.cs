using System;
using System.Threading.Tasks;
using MonoDevelop.Projects;

namespace MonoDevelop.ConnectedServices
{
	/// <summary>
	/// A specific instance of a connected service for a given project
	/// </summary>
	public interface IConnectedService
	{
		/// <summary>
		/// Gets the Id of the service
		/// </summary>
		string Id { get; }

		/// <summary>
		/// Gets the display name of the service to show to the user in the solution pad
		/// </summary>
		string DisplayName { get; }

		/// <summary>
		/// Gets the description of the service to display to the user in the services gallery.
		/// </summary>
		string Description { get; }

		/// <summary>
		/// Gets a description of the supported platforms. This is largely just informational as the service provider decides
		/// whether a project is supported or not.
		/// </summary>
		string SupportedPlatforms { get; }

		/// <summary>
		/// Gets the project that this service instance is attached to
		/// </summary>
		DotNetProject Project { get; }

		/// <summary>
		/// Gets the icon to display in the services gallery.
		/// </summary>
		Xwt.Drawing.Image GalleryIcon { get; }

		/// <summary>
		/// Gets a value indicating whether this <see cref="T:MonoDevelop.ConnectedServices.IConnectedService"/> is added to Project or not.
		/// This is independent of whether or not the dependencies are installed or the service has been configured or not. It does imply that 
		/// any code scaffolding that can be done has been done.
		/// </summary>
		bool IsAdded { get; }

		/// <summary>
		/// Gets the dependencies that will be added to the project
		/// </summary>
		IConnectedServiceDependency [] Dependencies { get; }

		/// <summary>
		/// Gets a value indicating whether ALL the depenencies are installed.
		/// </summary>
		bool AreDependenciesInstalled { get; }

		/// <summary>
		/// Gets the array of sections to be displayed to the user after the dependencies section.
		/// </summary>
		IConfigurationSection [] Sections { get; }

		/// <summary>
		/// Occurs when service is added to the project;
		/// </summary>
		event EventHandler<EventArgs> ServiceAdded;

		/// <summary>
		/// Adds the service to the project
		/// </summary>
		Task AddToProject ();
	}
}