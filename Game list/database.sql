CREATE TABLE games (
    id SERIAL PRIMARY KEY,
    title VARCHAR(100) NOT NULL,
    genre VARCHAR(50),
    platform VARCHAR(50),
    releasedate DATE,
    completed BOOLEAN DEFAULT false,
    rating INT CHECK (rating >= 1 AND rating <= 10)
);

INSERT INTO games (title, genre, platform, releasedate, completed, rating)
VALUES 
('The Witcher 3', 'RPG', 'PC', '2015-05-19', true, 10),
('Celeste', 'Platformer', 'PC', '2018-01-25', false, 9),
('Counter-Strike 2', 'FPS', 'PC', '2023-09-23', false, 7);
