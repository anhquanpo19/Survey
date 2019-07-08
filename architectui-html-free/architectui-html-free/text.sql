Ref {
  question.survey_id > Survey.ID
}


Ref {
  Survey.survey_author > user.ID
}

Table exam {
  exam_id bigint
  surver_id bigint
  user_id bigint
  number_question int
  total_score double
  time_score datetime
}

Table class{
  id bigint
  class_name varchar
  class_status boolean
}
Table class_user{
  class_id bigint
  user_id bigint
  status boolean
}
Ref{
  class_user.class_id > class.id
}
Ref{
  class_user.class_id > user.ID
}

Ref 
{ 
  exam.surver_id > Survey.ID
}
Ref {
  exam.user_id > user.ID
}