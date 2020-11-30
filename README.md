# ADcarryGap
프로젝트 변동사항 12월 1일

추가된 기능 : 
- 배틀레벨 브금
- 유닛 선택, 발사, 충돌 효과음
- 유닛 사망처리
- 한쪽팀 유닛 전부 사망시 게임 종료

1-1 Egg(B)에서 :
- bool 변수 ‘isOnFire(B)’ 추가
- 함수 ‘Take Fire Damage(B)’ 추가
- 불에 닿았을 때 즉시 체력이 20 감소하는 노드 삭제
- 불에 닿으면 ‘isOnFire(B)’가 True로, 불에서 빠져나오면 False로 설정되는 노드들 추가
 
1-2 Egg(W)에서 : 
- bool 변수 ‘isOnFire(W)’ 추가
- 함수 ‘Take Fire Damage(W)’ 추가
- 불에 닿았을 때 즉시 체력이 20 감소하는 노드 삭제
- 불에 닿으면 ‘isOnFire(B)’가 True로, 불에서 빠져나오면 False로 설정되는 노드들 추가
- 함수 ‘Set Unit Dead(W)’ 추가

2 BattleLevel에서 : 
- ‘Turn Change’함수 이벤트그래프에서 게임매니저의 커스텀이벤트가 실행 되도록 노드추가 
- 유닛 선택시 사운드 재생하는 노드 추가
- 유닛 발사될 때 사운드 재생하는 노드 추가
 

 
3 GameManager에서 :
- 함수 ‘Apply Fire Damage(W)’ 추가
- 함수 ‘Apply Fire Damage(B)’ 추가
- 커스텀이벤트 ‘Black Turn Starts(GM)’ 추가
- 커스텀이벤트 ‘White Turn Starts(GM)’ 추가
- 함수 ‘Check Units Survival’ 추가
- 함수 ‘Black Wins’ 추가
- 함수 ‘White Wins’ 추가
- 게임 시작 시 배경음악 재생하는 노드 추가
 
 
4 BP_Level_UI 에서 : 
	- 화염지대 생성 알림 텍스트 안보이게 설정
	- 차례 알림 텍스트 가운데로 오게 수정
  
5 콘텐츠 브라우저에서 : 
	- 위젯 블루프린트 ‘BP_Black_Win’ 추가
	- 위젯 블루프린트 ‘BP_White_Win’ 추가
