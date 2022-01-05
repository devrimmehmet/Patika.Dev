# Master1
## git status neler değişti
## git add . en son yapılanı ekleme işlemi
aciklama eklendi
git commit 
açıklaması değişiyor commitin
git commit --amend -m "Master2 | bu amend ile eklenmiş yeni bir mesaj"
git branch -D branchismi // branch silmenizi sağlar
git commit -m "Master3 @| Liste Eklendi"

Commit Silme

commit
log 
status
resert
revert
commit değiştirme 
commit mesajı değiştirme
git diff d8976a1614175b87b3c6..e8562e19e30c9c93ca3 index.md
git branch
git branch header
git branch
git checkout header // headere geçti 
git checkout -b footer // footeri oluşturdu ve ona geçti
git checkout master // mastere geçtim
git branch -D footer // footeri sildi 
git checkout header // headera geçtim 
touch footer.md // footer.md dosyası ekledi.
git stash
git stash list
git stash clear
git stash pop // en üstteki kaydı geri getir. uygular ve değşiklikleri kaldırır.
git stash apply // değişiklikleri uygula ve kaldırma 

## HEADER Branch üzerinden gelen değişiklik...
### Merge
git add .

- git merge header // birleştirmek istediğim iki branchı belirtiyorum masterdayken header yazdım masterin icine headeri çektim mastere.
git log

git log -n 2 // son 2 değişimi göster

- git merge --squash footer // footeride mastere çekiyor ve son olarak bir commit yapma şansı veriyor.
git commit -m "Footer Master ile birleştirildi"

git reset --hard 213842384832  o değişiklikleri gösteriyor

### Rebase
git rebase header // headeri mastere ekledi.
git rebase footer // footeri çekti

git checkout header
 değişiklik yaptık 
 git add . 
git commit -m "HEADER 5 | index üzerinde liste değiştirildi."
git checkout master
git status // değişiklik varmı ?
sonra değişikliği masterdada yaptım diyelim
git commit -m "MASTER 1 | İndex üzerinde değişiklik yapıldı."
sonra
git merge header // cekmeye çalıştık 
//DİPNOT git merge --abort yaparak işlemi geride alabiliriz. birleşmenin öncesine gider
conflicts hatası verdi şimdi iki değişiklik var ve hangisi doğru hangisi yanlış ona karar vermeniz gerekiyor.
sonra gelen kısımda kalacak olana karar verip diğer kısmı siliyorsunuz.
git add .
git commit -m "Merge Completed"



