﻿namespace Mammon.Models.Actors;

public record LAWorkspaceActorState
{
	public string ResourceId { get; set; } = string.Empty;
	public ResourceCost? TotalCost { get; set; }
}