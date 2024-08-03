# Premier League MAUI 앱 [![English](https://img.shields.io/badge/Language-English-blue.svg)](README.md) [![한국어](https://img.shields.io/badge/Language-한국어-red.svg)](README.ko.md)

.NET MAUI를 사용하여 구현한 크로스 플랫폼 Premier League 학습용 앱

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnet214/maui-premierleague.svg)](https://github.com/jamesnet214/maui-premierleague/stargazers)
[![Issues](https://img.shields.io/github/issues/jamesnet214/maui-premierleague.svg)](https://github.com/jamesnet214/maui-premierleague/issues)

## 프로젝트 개요

이 Premier League 앱은 .NET MAUI(다중 플랫폼 앱 UI)를 사용하여 구현된 학습 중심 프로젝트입니다. 특히 WPF에서 크로스 플랫폼 개발로 전환하는 개발자들이 MAUI와 WPF 사이의 유사점과 차이점을 이해하는 데 좋은 예시가 됩니다.

<img width="400" alt="Tables" src="https://user-images.githubusercontent.com/52397976/193004770-75654ac4-ab56-4f4d-bd63-416110b94b18.png"> <img width="400" alt="Results" src="https://user-images.githubusercontent.com/52397976/193004945-4a76f3e2-3583-47e7-aef3-3dc10a265d3e.png">

## 주요 기술 및 구현 사항

#### 1. MVVM 아키텍처
- [x] 서드파티 프레임워크 없이 순수 MVVM 구현
- [x] 데이터 바인딩 및 커맨드의 적절한 사용

#### 2. UI 컴포넌트 및 스타일링
- [x] 네비게이션을 위한 TabBar 구현
- [x] 효율적인 리스트 렌더링을 위한 CollectionView 사용
- [x] 유연한 UI 디자인을 위한 사용자 정의 DataTemplate
- [x] 내장 테마 구현

#### 3. 크로스 플랫폼 디자인
- [x] 다양한 화면 크기에 대응하는 반응형 레이아웃
- [x] 필요한 경우 플랫폼별 적응

#### 4. 리소스 관리
- [x] 확장 가능한 그래픽을 위한 .svg 리소스 활용
- [x] 사용자 정의 모양을 위한 Geometry 구현

#### 5. MAUI 특화 기능
- [x] MAUI 특화 컨트롤 및 API 탐구
- [x] 네이티브 기능을 위한 플랫폼 호출(P/Invoke) 시연

## 기술 스택
- .NET 8.0
- .NET MAUI
- C# 10.0
- MVVM (Model-View-ViewModel) 패턴

## 시작하기

### 필요 조건
- Visual Studio 2022 이상 (Windows용)
- JetBrains Rider (Windows 또는 macOS용)
- .NET 8.0 SDK
- MAUI 워크로드 설치

### 설치 및 실행
#### 1. 리포지토리 클론:

```
git clone https://github.com/jamesnet214/maui-premierleague.git
```

#### 2. 솔루션 열기
- [x] Visual Studio (Windows 전용)
- [x] JetBrains Rider (Windows 및 macOS)

#### 3. 빌드 및 실행
- [x] Windows 11
- [x] macOS
- [x] iOS (시뮬레이터 또는 실제 기기)
- [x] Android (에뮬레이터 또는 실제 기기)

## WPF 개발자를 위한 학습 포인트

1. **친숙한 XAML**: MAUI는 XAML을 사용하므로 WPF 개발자가 쉽게 전환할 수 있습니다.
2. **크로스 플랫폼 고려사항**: 다양한 플랫폼에서 작동하는 UI 설계 방법을 학습합니다.
3. **모바일 우선 접근**: 데스크톱 중심에서 모바일 우선 디자인으로의 전환을 이해합니다.
4. **성능 최적화**: 모바일 기기에서의 앱 성능 최적화 기법을 탐구합니다.
5. **플랫폼별 기능**: 공유 코드베이스를 유지하면서 플랫폼별 기능을 구현하는 방법을 학습합니다.

## 프로젝트 구조

- **Views**: XAML 페이지 및 사용자 컨트롤 포함
- **ViewModels**: 프레젠테이션 로직 구현
- **Models**: 데이터 모델 및 비즈니스 로직 정의
- **Services**: 데이터 액세스 및 기타 서비스 포함
- **Resources**: 스타일 및 이미지와 같은 공유 리소스 저장

## 기여하기

프로젝트 개선에 기여하고 싶으시다면 Pull Request를 보내주세요. 모든 형태의 기여를 환영합니다!

## 라이선스

이 프로젝트는 MIT 라이선스 하에 배포됩니다. 자세한 내용은 [LICENSE](https://github.com/jamesnet214/maui-premierleague/blob/main/LICENSE) 파일을 참조하세요.

## 연락처
- 웹사이트: https://jamesnet.dev
- 이메일: james@jamesnet.dev, vickyqu115@hotmail.com

이 Premier League 앱을 통해 MAUI의 크로스 플랫폼 개발 세계를 탐험해보세요!

## 추가 자료

[.NET Conf 2022.09 by .NET Dev](https://www.youtube.com/watch?v=Z6Z3qgHYaOg&t=16427s)
