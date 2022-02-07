using Refit;
using Sabuto.Trello.Core.Models.Card;

namespace Sabuto.Trello.Core.Services.Interfaces;

/// <summary>

/// The card interface

/// </summary>

public interface ICard
{
    
    /// <summary>
    /// Gets the card using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of card</returns>
    [Get("/cards/{id}")]
    Task<ApiResponse<Card>> GetCard(string id);

    /// <summary>
    /// Deletes the card using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of object</returns>
    [Delete("/card/{id}")]
    Task<ApiResponse<object>> DeleteCard(string id);

    [Post("/cards/")]
    Task<ApiResponse<Card>> CreateCard([Query]NewCard card);
}