CREATE TABLE
    exercises (
        id SERIAL PRIMARY KEY,
        name VARCHAR(100) NOT NULL UNIQUE,
        category VARCHAR(20) NOT NULL, -- Strength, Cardio
        muscle_group VARCHAR(30) NOT NULL, -- Chest, Back, Legs, Shoulders, Arms, Core, FullBody
        equipment VARCHAR(30) NOT NULL, -- Bodyweight, Dumbbell, Barbell, Machine, None
        description TEXT,
        is_active BOOLEAN NOT NULL DEFAULT TRUE,
        created_at TIMESTAMP NOT NULL DEFAULT NOW (),
        updated_at TIMESTAMP
    );