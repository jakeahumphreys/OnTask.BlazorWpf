using System.Collections.Generic;
using OnTask.BlazorWpf.Data.Collections;

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
}