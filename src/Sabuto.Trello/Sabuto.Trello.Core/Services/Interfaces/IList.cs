using Refit;
using Sabuto.Trello.Core.Models.Card;

namespace Sabuto.Trello.Core.Services.Interfaces;

/// <summary>

/// The list interface

/// </summary>

public interface IList
{
    /// <summary>
    /// Gets the list using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of object</returns>
    [Get("/lists/{id}")]
    Task<ApiResponse<object>> GetList(string id);

    /// <summary>
    /// Gets the cards using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of i enumerable card</returns>
    [Get("/lists/{id}/cards")]
    Task<ApiResponse<IEnumerable<Card>>> GetCards(string id);
}