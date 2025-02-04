IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobStageFieldPrompt' AND COLUMN_NAME = 'PromptBefore')
BEGIN
ALTER TABLE ussSFJobStageFieldPrompt ADD PromptBefore bit
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'ussSFJobStageFieldPrompt' AND COLUMN_NAME = 'PromptAfter')
BEGIN
ALTER TABLE ussSFJobStageFieldPrompt ADD PromptAfter bit
END