using System;
using OnTask.BlazorWpf.Data.Activities;

namespace OnTask.BlazorWpf.Services;

public sealed class ActivityService
{
    private readonly ActivityRepository _repository;

    public ActivityService(ActivityRepository activityRepository)
    {
        _repository = activityRepository;
    }

    public Activity GetActivityById(Guid id)
    {
        return _repository.GetById(id);
    }

    public void AddActivity(Activity activity)
    {
        _repository.Add(activity);
    }
}