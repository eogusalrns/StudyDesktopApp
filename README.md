# StudyDesktopApp
C# 데스크톱 앱 개발 학습 리포지토리

## Winform App
오랜 테스트를 거쳐서 안정성이 확보
참고할 데이터와 소스가 많다

## WPF App
비교적 최신 기술로서 XML(Xaml)을 이용하여서 안드로이드 전환 가능
GUI를 표현하는데 Winform보다 높은 성능을 제공

==> WPF가 더 유용할 것 같다

## 개발자 팁
- 두번 이상 사용된 코드는 메서드화

- SQL 연결해서 작업할때 DML문 테이블 스크립팅 활용 (직접 타이핑할 필요없고, 오타 방지) 생산성 및 정확도 향상

- NuGet에서 패키지 다운받아 폼 꾸미기 세련됨 ex) MetroModernUI![MetroModernUI](https://user-images.githubusercontent.com/54261552/111722086-7d1d0500-88a4-11eb-9346-e7cb6751598b.png)


- try catch 문 예외 처리기 (스레드 단위로 한번만)
- 
## SQL Injection 방지법
-특수문자를 못쓰게한다(필터링 메서드로 Replace시킨다) ex) .replace("--","");
-

## XXS(Cross Site Scripting) 방지법
