namespace OkoloIt.Utilities.Result
{
    /// <summary>
    /// Итерфейс объекта возврата.
    /// </summary>
    public interface IResult
    {
        #region Public Properties

        /// <summary>
        /// Ошибка.
        /// </summary>
        bool IsFailed { get; }

        /// <summary>
        /// Сообщение.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Успех.
        /// </summary>
        bool IsSuccess { get; }

        #endregion Public Properties
    }
}