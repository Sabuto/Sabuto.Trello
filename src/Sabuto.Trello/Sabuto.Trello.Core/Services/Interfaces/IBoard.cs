using Refit;
using Sabuto.Trello.Core.Models.Action;
using Sabuto.Trello.Core.Models.Board;
using Sabuto.Trello.Core.Models.Card;
using Sabuto.Trello.Core.Models.Checklist;
using Sabuto.Trello.Core.Models.Label;
using Sabuto.Trello.Core.Models.List;

namespace Sabuto.Trello.Core.Services.Interfaces;

/// <summary>

/// The board interface

/// </summary>

public interface IBoard
{
    /// <summary>
    /// Gets the board using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of board</returns>
    [Get("/boards/{id}")]
    Task<ApiResponse<Board>> GetBoard(string id);

    /// <summary>
    /// Creates the board using the specified board
    /// </summary>
    /// <param name="board">The board</param>
    /// <returns>A task containing an api response of board</returns>
    [Post("/boards")]
    Task<ApiResponse<Board>> CreateBoard(NewBoard board);

    /// <summary>
    /// Deletes the board using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of object</returns>
    [Delete("/boards/{id}")]
    Task<ApiResponse<object>> DeleteBoard(string id);

    /// <summary>
    /// Gets the actions using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of i enumerable trello action</returns>
    [Get("/boards/{id}/actions")]
    Task<ApiResponse<IEnumerable<TrelloAction>>> GetActions(string id);

    /// <summary>
    /// Gets the stars using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of i enumerable board stars</returns>
    [Get("/boards/{id}/boardStars")]
    Task<ApiResponse<IEnumerable<BoardStars>>> GetStars(string id);

    /// <summary>
    /// Gets the labels using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of i enumerable label</returns>
    [Get("/boards/{id}/labels")]
    Task<ApiResponse<IEnumerable<Label>>> GetLabels(string id);

    /// <summary>
    /// Creates the label using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <param name="label">The label</param>
    /// <returns>A task containing an api response of label</returns>
    [Post("/boards/{id}/labels")]
    Task<ApiResponse<Label>> CreateLabel(string id, Label label);

    /// <summary>
    /// Gets the memberships using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of i enumerable board member</returns>
    [Get("/boards/{id}/memberships")]
    Task<ApiResponse<IEnumerable<BoardMember>>> GetMemberships(string id);

    /// <summary>
    /// Marks the as viewed using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of object</returns>
    [Post("/boards/{id}/markedAsViewed")]
    Task<ApiResponse<object>> MarkAsViewed(string id);

    /// <summary>
    /// Gets the all cards using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of object</returns>
    [Get("/boards/{id}/cards")]
    Task<ApiResponse<object>> GetAllCards(string id);

    /// <summary>
    /// Gets the card using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <param name="cardId">The card id</param>
    /// <returns>A task containing an api response of card</returns>
    [Get("/boards/{id}/cards/{cardId}")]
    Task<ApiResponse<Card>> GetCard(string id, string cardId);

    /// <summary>
    /// Gets the custom fields using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of i enumerable custom field</returns>
    [Get("/boards/{id}/customFields")]
    Task<ApiResponse<IEnumerable<CustomField>>> GetCustomFields(string id);

    /// <summary>
    /// Gets the lists using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of i enumerable trello list</returns>
    [Get("/boards/{id}/lists")]
    Task<ApiResponse<IEnumerable<TrelloList>>> GetLists(string id);

    /// <summary>
    /// Gets the checklists using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of i enumerable checklist</returns>
    [Get("/boards/{id}/checklists")]
    Task<ApiResponse<IEnumerable<Checklist>>> GetChecklists(string id);

    /// <summary>
    /// Creates the email key using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of email key</returns>
    [Post("/boards/{id}/emailKey/generate")]
    Task<ApiResponse<EmailKey>> CreateEmailKey(string id);
    
    /// <summary>
    /// Creates the calendar key using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of object</returns>
    [Post("/boards/{id}/calendarKey/generate")]
    Task<ApiResponse<object>> CreateCalendarKey(string id);

    /// <summary>
    /// Gets the power ups using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <param name="filter">The filter</param>
    /// <returns>A task containing an api response of object</returns>
    [Get("/boards/{id}/plugins")]
    Task<ApiResponse<object>> GetPowerUps(string id, PowerUpsOptions filter = PowerUpsOptions.enabled);
}