# 바바리안은 다 뿌신다(바.다.뿌)


## 📖 목차
1. [프로젝트 소개](#프로젝트-소개)
2. [기술스택](#기술스택)
3. [게임 소개](#게임-소개)
4. [팀소개](#팀소개)
5. [프로젝트 계기](#프로젝트-계기)
6. [와이어프레임](#와이어프레임)
7. [주요기능](#주요기능)
8. [개발기간](#개발기간)
9. [Trouble Shooting](#trouble-shooting)
    
## 👨‍🏫 프로젝트 소개
<h4>2D Top-Down 뷰의 로그라이크 RPG 게임입니다. 
   
## 📚️ 개발 환경 및 타겟 플랫폼

### ✔️ Language: C#
### ✔️ Engine: Unity_2022.3.17f
### ✔️ Editor: Visual Studio 2022_17.9.6
### ✔️ Platform : PC / itch.io

## 🎮 게임소개
- 🪓게임이름 
   <b2> `바바리안은 다 뿌신다(바.다.뿌)`
 
- 📎 게임설명
  - 플레이어는 탑의 정상에 오르기 위해 던전에 존재하는 몬스터들을 처치하며 앞으로 나아갑니다. 

- 🎮 게임 플레이
  - https://seeun0815.itch.io/barbarians-smash-everything

- 🕹️ 조작법
![image](https://github.com/user-attachments/assets/9fbb53fe-d9e6-4fe1-8d72-495f8fbb5e32)

  - WASD : 플레이어를 상하좌우 방향으로 이동시킵니다.
  - Shift + WASD : 플레이어는 shift 키를 누른 상태로 이동하여 질주할 수 있습니다. 
  - E : E 버튼을 누르면 인벤토리를 열 수 있습니다. 장착형 아이템은 드래그&드랍을 통해, 소비형 아이템은 마우스 우클릭을 통해 사용할 수 있습니다.
  - Mouse : 마우스를 클릭하면 플레이어가 바라보는 방향으로 공격을 합니다. 
  - X : 플레이어의 전투 모드를 해제/활성화 시킬 수 있습니다.


## 👨‍👨‍👦 팀소개
- 팀장 : 이경현 - Player, Inventory, Item, Shop , GameManager
- 부팀장 : 김민우 - Monster, Clock & Tax System, Light, Manual, CutScene
- 팀원 : 김신우 - Boss, NPC, Stat System, Battle System , Character System
- 팀원 : 최세은 - Stage Move, Inchant, Game Save·Load, Dialogue & Selection, Monster Spawner, Player Skill 


## 프로젝트 계기
- 웹툰 [게임 속 바바리안으로 살아남기]를 읽고, 작중 묘사되는 것과 같은 하드코어 로그라이크 RPG를 만들어보고 싶었습니다.

## 와이어프레임
![image](https://github.com/user-attachments/assets/f81eed1b-6151-4aec-96a9-c1bf493f0b38)


## 💜 주요기능

- Physics2D와 NavMesh2D를 활용한 캐릭터 추적 시스템


     ![image](https://github.com/user-attachments/assets/a7e0db5b-4422-4fdb-af43-ed07a9ee6def)

- FSM 패턴을 이용한 캐릭터(Player / NPC / Monster) 디자인

     ![image](https://github.com/user-attachments/assets/b247cedd-055f-41df-ac01-b9f31ef23df0)



- CSV, Json 데이터 사용

     ![image](https://github.com/user-attachments/assets/509d9360-c8f6-47f1-84e6-7b03079fe4c3)




## ⏲️ 개발기간
- 2024.06.27(목) ~ 2024.08.20(화)
 ![image](https://github.com/user-attachments/assets/77f4f9c2-d7c7-46a5-b25c-a6fd4f99c7cb)





## Trouble Shooting
- 애니메이션 기능 개선
![image](https://github.com/user-attachments/assets/af02afb8-7b7f-4c58-a7e5-b1e3cf9e0755)


- 몬스터의 전리품이 정상적으로 드랍되지 않아, 몬스터가 오브젝트 풀에 반환이 안되는 현상
![image](https://github.com/user-attachments/assets/54f88ada-d0b0-4423-88a8-380b83709b30)


- 보스의 공격이 플레이어에게 데미지를 입히지 못했던 현상
![image](https://github.com/user-attachments/assets/7ccb6589-b319-4d42-a2e8-4907055e1952)

- 기존 Save / Load 기능이 WebGL 환경에서 동작하지 않는 현상
![image](https://github.com/user-attachments/assets/f8ccc5e4-330f-4f76-9aaa-52c163a342c1)
![image](https://github.com/user-attachments/assets/d57827ec-dcb9-4913-89d8-31ebc71ffb8f)




