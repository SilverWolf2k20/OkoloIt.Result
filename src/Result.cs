using OkoloIt.Utilities.Result.Out;

namespace OkoloIt.Utilities.Result
{
    /// <summary>
    /// Данные возврата метода.
    /// </summary>
    public class Result : IResult
    {
        #region Protected Constructors

        /// <summary>
        /// Создает экземпляр класса.
        /// </summary>
        /// <param name="success">Состояние результата.</param>
        /// <param name="message">Сообщение результата.</param>
        protected Result(bool success, string message)
        {
            IsSuccess = success;
            Message = message;
        }

        #endregion Protected Constructors

        #region Public Properties

        /// <summary>
        /// Ошибка.
        /// </summary>
        public bool IsFailed => !IsSuccess;

        /// <summary>
        /// Сообщение.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Успех.
        /// </summary>
        public bool IsSuccess { get; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Возврощает объект класса при ошибке с сообщением.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        /// <returns>Объект класса.</returns>
        public static ResultFail Fail(string message)
            => new ResultFail(message);

        /// <summary>
        /// Возврощает объект класса при успехе.
        /// </summary>
        /// <typeparam name="T">Тип возвращаемого значения.</typeparam>
        /// <param name="value">Возвращаемное значение.</param>
        /// <returns>Объект класса.</returns>
        public static ResultOk<T> Ok<T>(T value)
            => new ResultOk<T>(value);

        #endregion Public Methods
    }
}