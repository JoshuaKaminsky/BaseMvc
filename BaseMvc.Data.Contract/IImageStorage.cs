namespace BaseMvc.Data.Contract
{
    /// <summary>
    /// Interface for storing images
    /// </summary>
    public interface IImageStorage
    {
        /// <summary>
        /// Method for saving images
        /// </summary>
        /// <param name="image">The image as a byte array</param>
        /// <returns>The path to the stored image</returns>
        ImageSource Save(byte[] image);

        /// <summary>
        /// Method for removing images
        /// </summary>
        /// <param name="source">The path of the image to remove</param>
        /// <returns>True if successful, otherwise false</returns>
        bool Delete(string source);

        /// <summary>
        /// Method for retrieving saved images
        /// </summary>
        /// <param name="source">The path of the image to retrieve</param>
        /// <returns>The image as a byte array</returns>
        byte[] Retrieve(string source);
    }
}
