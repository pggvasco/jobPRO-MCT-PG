

ALTER TABLE [dbo].[ussChecklistChecklistTasks]  WITH CHECK ADD  CONSTRAINT [FK_ussChecklistTasks_ussChecklist] FOREIGN KEY([ChecklistID])
REFERENCES [dbo].[ussChecklist] ([ID])


ALTER TABLE [dbo].[ussChecklistChecklistTasks] CHECK CONSTRAINT [FK_ussChecklistTasks_ussChecklist]


ALTER TABLE [dbo].[ussChecklistChecklistTasks]  WITH CHECK ADD  CONSTRAINT [FK_ussChecklistTasks_ussChecklistTask] FOREIGN KEY([ChecklistTaskID])
REFERENCES [dbo].[ussChecklistTask] ([ID])


ALTER TABLE [dbo].[ussChecklistChecklistTasks] CHECK CONSTRAINT [FK_ussChecklistTasks_ussChecklistTask]


