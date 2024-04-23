# REST
/api/v1/admin/quizzess/{quizId}

[ { "operationType": 0, "path": "title", "op": "replace", "value": "New Quiz Title" }, { "operationType": 1, "path": "items/-", "op": "add", "value": { "question": "What is the capital of France?", "correctAnswer": "Paris", "incorrectAnswers": ["London", "Berlin", "Madrid"] } } ]
