using Refit;
using Sabuto.Trello.Core.Models.Checklist;

namespace Sabuto.Trello.Core.Services.Interfaces;

/// <summary>

/// The checklist interface

/// </summary>

public interface IChecklist
{
    /// <summary>
    /// Gets the checklist using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of checklist</returns>
    [Get("/checklists/{id}")]
    Task<ApiResponse<Checklist>> GetChecklist(string id);

    /// <summary>
    /// Deletes the checklist using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of object</returns>
    [Delete("/checklists/{id}")]
    Task<ApiResponse<object>> DeleteChecklist(string id);

    /// <summary>
    /// Gets the checkitem using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <param name="idCheckItem">The id check item</param>
    /// <returns>A task containing an api response of check item</returns>
    [Get("/checklists/{id}/checkItems/{idCheckItem}")]
    Task<ApiResponse<CheckItem>> GetCheckitem(string id, string idCheckItem);

    /// <summary>
    /// Gets the check items using the specified id
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an api response of i enumerable check item</returns>
    [Get("/checklists/{id}/checkItems")]
    Task<ApiResponse<IEnumerable<CheckItem>>> GetCheckItems(string id);
}