# mauiconf

## 1. 소개

TBD ...

안녕하세요. 닷넷 개발자 이재웅입니다.  
먼저 제 소개부터 하겠습니다.  
저는 WPF Framework을 전문적으로 만들고 있으며 GitHub 오픈소스 활동도 열심히 하고 있는 닷넷 개발자입니다.  
그리고 개발자 커뮤니티 사이트인 닷넷데브에서 운영진으로도 활동 하고 있습니다.   

그리고 지금 이 발표가 제 개인적으로는 3번째 인데, 아직도 적응 되질 않고, 여전히 어렵고, 부담스럽지만 이번에도 열심히 준비했습니다.  
제가 작년 컨퍼런스를 통해 발표했던 Blazor 외부 인증, 그리고 올해 발표했던 WPF Binding에 이어   
이번에는 Mac 환경에서 MAUI 앱을 만들고 iPhone 실행 까지 해보는 과정을 담은 이 영상을 지금 소개하고자 합니다.

그럼 시작해볼까요?  

## 2. 준비물

먼저 준비물을 체크하겠습니다.

첫번째로는 맥북이나 아이맥, 맥미니와 같은 Mac OS 기반의 디바이스가 필요합니다.  
그 다음으로는 iPhone 8 버전 이상의 스마트폰이 필요한데요. 그 이유는 MAUI가 8 버전 이하에서는 지원을 하고 있지 않기 때문입니다.
참고로 제가 준비한 영상은 iPhone에서 실행하는 것 까지를 목적으로 하기 때문에 맥과 아이폰이 필요한 것이고요.  
혹시 이러한 준비가 되어있지 않을 경우에는 맥 또는 윈도우에서 각 OS 버전에 맞는 Visual Studio를 설치하고, 그리고 아이폰 또는 안드로이드 시뮬레이터를 통해 동일한 결과를 확인할 수 있습니다. 

## 3. 소프트웨어 설치 확인

다음으로는 소프트웨어를 체크하겠습니다.

가장 먼저 XCode가 필요합니다. 사실 Visual Studio for Mac 에서 독자적으로 앱이 컴파일 되는 것이 아니라 XCode 컴파일러와의 연계로 실행되기 때문에 반드시 XCode가 사전에 준비되어야 하는 것입니다. 그리고 XCode는 AppStore를 통해 무료로 설치할 수 있습니다.

그 다음으로는 Visual Studio for Mac 버전이 필요합니다. Visual Studio for Mac 버전은 Microsoft 공식 홈페이지에서 직접 다운받을 수 있습니다.

그리고 저는 M1 Chip이 탑재된 Macbook 16인치 버전을 사용하고 있습니다.
그리고 앞서 설명드린 XCode와 Visual Studio for Mac 버전을 미리 설치해둔 상태입니다.

이제 필요한 준비를 다 마쳤으니 바로 프로젝트를 만들어보도록 하겠습니다.

## 4. 개발

- 프로젝트 생성
- 다중 플랫폼 MAUI 앱 선택
- App.xaml.cs 클릭
- Current.UserAppTheme 다크로 고정
- MainPage = new AppShell();
- AppShell.xaml 클릭
- Shell 안에 있는 Content 영역 모두 지우기
- TabBar 및 Tab 2개 추가
- Tab에서 Title 속성 입력
- Images에 svg 파일 추가 및 빌드 옵션 MauiImage 선택
- 다시 Tab으로 돌아와서 Icon에 svg 입력, 단 .png로 선언한다.
- 각 탭에 ShellContent 추가
- 루트에 Pages 폴더 추가
- Tables ContentPage 신규 추가
- Grid를 통해 간단하게 레이아웃 구성하고 Label과 CollectionView 추가

```xaml
<StackLayout>
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>
        <Label Text="EPL 2022/2023"
               FontSize="Medium"                   
               Margin="20, 10, 20, 10"/>
        <CollectionView Grid.Row="1"
                        SelectionMode="Single"
                        BackgroundColor="#191919"
                        ItemsSource="{Binding Teams}"
                        ItemTemplate="{StaticResource ClubTemplate}">
        </CollectionView>
    </Grid>
</StackLayout>
```

- SelectionMode를 Single으로 지정해야 아이템 Selection 기능이 활성화 된다.
- 그 다음 TablesViewModel을 추가한다.
- 최소한의 MVVM 바인딩을 사용하 것이므로 외부 툴킷은 설치하지 않음.
- 다시 루트로 와서 Models 폴더 추가
- ClubModel 추가 및 속성 추가
- 다시 뷰모델로 돌아와서 List<ClubModel> Teams 속성 추가
- 샘플 데이터르 반환하는 메서드 구현
- 다시 테이블스 페이지로 돌아가서 CollectionView ItemsSource에 Teams를 바인딩한다.
- 다음 리스트 항목을 디자인하기 새로운 데이터 템플릿을 추가한다. Styles.xaml
- ClubTemplate 이름으로 디자인한다.
- StackLayout 기본
- VisualStateManager.VisualStateGroup
- VisualState name=CommonState
- VisualState name=Normal
- Setter property=BackgroundColor value=Transparent
- VisualState name=Selected
- ""
- Grid Design
- 엠블럼 로고, 구단이름, 지역명, 승점, 승, 무, 패
- Binding
- 다시 컬렉션뷰에서 ClubTemplate StaticResource 바인딩
- 중간 실행
