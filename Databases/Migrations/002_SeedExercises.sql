INSERT INTO
    exercises (name, category, muscle_group, equipment, description)
VALUES
    ('Push-Up', 'Strength', 'Chest', 'Bodyweight', 'Classic bodyweight press targeting chest, shoulders, and triceps.'),
    ('Bench Press', 'Strength', 'Chest', 'Barbell', 'Barbell pressed from the chest while lying on a flat bench.'),
    ('Pull-Up', 'Strength', 'Back', 'Bodyweight', 'Hanging from a bar, pull the body upward until the chin clears the bar.'),
    ('Deadlift', 'Strength', 'Back', 'Barbell', 'Lift a loaded barbell from the floor to hip level, keeping the back neutral.'),
    ('Barbell Squat', 'Strength', 'Legs', 'Barbell', 'Bar racked on the upper back, squat down and drive back up through the legs.'),
    ('Walking Lunges', 'Strength', 'Legs', 'Dumbbell', 'Step forward into alternating lunges while holding dumbbells at the sides.'),
    ('Overhead Press', 'Strength', 'Shoulders', 'Barbell', 'Press a barbell from shoulder height to overhead while standing.'),
    ('Lateral Raise', 'Strength', 'Shoulders', 'Dumbbell', 'Raise dumbbells out to the sides to shoulder height to target the deltoids.'),
    ('Bicep Curl', 'Strength', 'Arms', 'Dumbbell', 'Curl dumbbells from the sides up toward the shoulders to isolate the biceps.'),
    ('Tricep Dip', 'Strength', 'Arms', 'Bodyweight', 'Lower and raise the body using parallel bars or a bench to target the triceps.'),
    ('Plank', 'Strength', 'Core', 'Bodyweight', 'Hold a straight-body position on forearms and toes to build core stability.'),
    ('Russian Twist', 'Strength', 'Core', 'Bodyweight', 'Seated twisting motion targeting the obliques and core.'),
    ('Leg Press', 'Strength', 'Legs', 'Machine', 'Push a weighted platform away using the legs while seated in a machine.'),
    ('Burpee', 'Cardio', 'FullBody', 'Bodyweight', 'Squat, kick into a plank, push-up, then jump up explosively; a full-body conditioning move.'),
    ('Treadmill Running', 'Cardio', 'FullBody', 'Machine', 'Steady-state or interval running on a treadmill for cardiovascular conditioning.'),
    ('Jump Rope', 'Cardio', 'FullBody', 'None', 'Skipping rope at a steady pace to build cardiovascular endurance and coordination.')
ON CONFLICT (name) DO NOTHING;
