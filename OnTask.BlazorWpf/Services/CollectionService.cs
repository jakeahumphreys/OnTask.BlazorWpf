using System;
using System.Collections.Generic;
using OnTask.BlazorWpf.Data.Collections;
using OnTask.BlazorWpf.Data.Tasks;
using OnTask.BlazorWpf.Pages.PageModels;

namespace OnTask.BlazorWpf.Services;

public class CollectionService
{
    private readonly CollectionRepository _collectionRepository;

    public CollectionService(CollectionRepository collectionRepository)
    {
        _collectionRepository = collectionRepository;
    }

    public List<Collection> GetAllCollections()
    {
        return _collectionRepository.GetAll();
    }

    public void CreateCollection(CreateCollectionModel createCollectionModel)
    {
        var collection = new Collection
        {
            Id = Guid.NewGuid(),
            Name = createCollectionModel.Name,
            Tasks = new List<Task>(),
            IsArchived = false,
            IsFocused = false
        };
        
        _collectionRepository.Create(collection);
    }

    public Collection GetCollectionById(Guid id)
    {
        //Need to look at error handling here
        return _collectionRepository.GetById(id);
    }
}