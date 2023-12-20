using System.ComponentModel.DataAnnotations;

namespace ConvictConditioning.Models;

public class Exercise {
  [Required]
  public int Id { get; set; }
  [Required]
  public string? Title {  get; set; }
  [Required]
  public ExerciseType Type { get; set; } = ExerciseType.None;

  [Required]
  [Range(1, 10, ErrorMessage = "The Level must be between 1 and 10.")]
  public int Level { get; set; }

  [Required]
  public string ProgressOne { get; set; } = string.Empty;
  [Required]
  public string ProgressTwo { get; set; } = string.Empty;
  [Required]
  public string ProgressThree { get; set; } = string.Empty;
}

public enum ExerciseType {
    None,
    Pushups,
    Squats,
    Pullups,
    Raises,
    Bridges,
    HandstandPushups
}