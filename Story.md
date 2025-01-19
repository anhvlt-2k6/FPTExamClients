# Đại học FPT: khi sinh viên gian lận và hack vào server trường

*Lấy từ nguồn:* `https://tinhte.vn/thread/dai-hoc-fpt-khi-sinh-vien-gian-lan-va-hack-vao-server-truong.1091706/`

---

Trường Đại Học FPT (FU) số 8 Tôn Thất Thuyết - Cầu Giấy - Hà Nội (Toà nhà Detect - đối diện bến xe Mĩ Đình) Trong 3 năm nay, FU có thực hiện việc thi cử online bằng phần mềm chuyên dụng của trường, được nhà trường đặt hàng của Phan Trường Lâm (LamPT) có 2 phiên bản đều được code bằng C# .NET:  
1- bản EOS Client dùng thi môn Business English (BE).  
2- bản IT Client thi các môn Software Engineering: Java, C#, C/C+-  Computer Network, Operating System (OS), Introduction to Database, ...

Cả 2 bản này thì sẽ lấy đề từ Server trường về máy tính sinh viên, sinh viên làm trên máy, sau đó khi kết thúc, bài làm của sinh viên sẽ được lưu 1 bản thành file .dat tại máy sinh viên, và gửi bài thi của sinh viên về Server

Tóm tắt nội dung:  
Sinh viên HieuDM và các sinh viên khác có hành vi gian lận thi cử tại FU, nổi lên đỉnh điểm là nhóm sinh viên này vì lý do thù hận với tôi nên lợi dụng 1 bug để tiến hành hack vào server FU để sửa bài thi của tôi và 1 người bạn của tôi, nhằm mục đích bắt chúng tôi học lại, nhóm này còn tuyên bố là sẽ không tôi này ra được trường vì sẽ sửa bài liên tục ở các kỳ thi, làm cho tôi không thể qua được 1 môn nào. Tôi đã phát hiện ra hành động này và báo cáo với FU để tiến hành giải quyết. Tuy nhiên, FU vẫn hợp tác với tôi để giải quyết. Sau đó, tôi đã tiến hành hack vào server FU rồi quay video lại và gửi cho BGH FU để giải quyết, BGH FU đã nhận video và cám ơn về sự hợp tác của tôi. Tuy nhiên sau thời gian dài chờ đợi hơn 2 tháng thì tôi có cảm giác như vụ việc vẫn chưa được giải quyết.

Bạn có thể Download toàn bộ tài liệu liên quan đến bài viết. Tất cả các file password giải nén đều là: `hvaonline.net`  
\* Collection - HVA version.rar Link Download:
```
Ubuntu One Server: http://ubuntuone.com/0J8ot5qlyqSH85dhUpY5uR
Mediafire Server: http://www.mediafire.com/?0uur4ip5aezjd31 
```

Đây là file chứa toàn bộ dữ liệu gửi cho trường đại học FPT:  
-  Video Hack vào Server trường đại học FPT để sửa bài thi của 1 sinh viên do chính tôi thực hiện (Phan Lê Việt Anh - Sinh viên năm 4 đại học FPT)  
-  Phần Mềm EOS Client - Edited version Coded by Đỗ Minh Hiếu (HieuDM - Sinh viên năm thứ 3 đại học FPT, mã số sinh viên: 01570. Email: `HieuDM01570@fpt.edu.vn`)  
-  1 Loạt ảnh bằng chứng mà tôi đã tiến hành điều tra được nhóm sinh viên HieuDM đã gian lận, và hack vào Server sửa bài thi của sinh viên khác.

\* IT Client Version 3 và 4.
```
Ubuntu One Server: http://ubuntuone.com/5DmWmrCC1F6uBBVkW7621P
Mediafire Server: http://www.mediafire.com/?os5553ef15s1vvw
``` 

Đây là Các bản IT Client nhà trường cung cấp cho sinh viên FU để tiến hành việc thử cử online trên laptop của sinh viên. Do đã trải qua 3 năm liền, nên mình chỉ còn lưu Version 3 và 4. mình up lên cho các bạn tham khảo.

\* Send Email.rar
```
Ubuntu One Server: http://ubuntuone.com/35R2kPLveYhVpbkaqRtwO5
Mediafire Server: http://www.mediafire.com/?25hrxgy9w8pfsl7
```            

Đây là 1 số ảnh để dẫn chứng 1 vài cuộc hội thoại và gửi tài liệu điều tra cho FU.

\* gmail and reset hotmail.rar
```
Ubuntu One Server: http://ubuntuone.com/2p79M0RQYHq9G5WfNV00jd
Mediafire Server: http://www.mediafire.com/?876sao7by4sameu 
```            

Đây là video tôi login vào `dohieu1991@gmail.com` và kiểm tra email: [dohieu1991@hotmail.com](mailto:dohieu1991@hotmail.com)

Sau đây là toàn bộ câu chuyện đầy đủ:

### **I. Tìm ra list sinh viên gian lận môn Business English**

Kết thúc buổi học vào 12h trưa. đang đói nên chạy vào thư viện rủ thằng bạn đi ăn.
```
XXX : thằng HieuDM mới có cái phần mềm gian lận BE, tao thấy bọn nó copy usb cho nhau dùng.
I : Đâu, có không? Mang đây tao xem xem nó làm gì nào.
XXX : Đây, trong usb tao có. vừa nãy có thằng mượn usb tao để copy. nó đã cut rồi nhưng chả hiểu sao vẫn còn.
I : Mày lại dùng recuva chứ gì. lol
XXX : Nhưng mà thằng đấy nó nói là phải đăng ký với thằng HieuDM mới dùng được mày ạ, thấy bảo nó mã hoá ác lắm, chắc là nó dùng cái Obfuscator rồi
I : Cứ đưa đây tao xem cho, có khi tao dùng wireshark là túm được cả đống sinh viên gian lận đấy chứ. (Trong đầu lúc này đang nghĩ, cái file chạy thì chúng nó copy usb cho nhau rồi, nên chắc license không nằm trong file chạy, thế thì HieuDM sẽ check license online, thằng này chắc mới code nên không mã hoá phần gửi nhận giữa Server với client đâu, cứ clear text là đọc được hết)
XXX : Dùng wireshark thế nào cơ? mày làm tao xem với.
I : OK. 
``` 

Bật laptop -> Copy EOS Client -> Chạy wireshark -> Capture -> chạy EOS Client -> Điền bừa cái Exam Code rồi nhấn Start Exam -> đợi khoảng 10s -> tắt EOS Client -> tắt capture -> bật đống wireshark vừa lên đọc -> tìm ngay mấy cái GET packet -> lấy được list sinh viên -> up list sinh viên này lên facebook -> đi ăn  

Sau 3 ngày liền liên tục tranh cãi và chửi nhau với nhóm sinh viên này trên facebook, sau đó đã bị 1 nhóm rất đông sinh viên chặn đường hành hung, hiệu phó Nguyễn Xuân Phong (PhongNX) đã chỉ đạo 2 nhân viên của trường đưa đi viện, sau đó gia đình đã liên lạc với nhà trường để xử lý thì PhongNX có trả lời là do 1 nhóm bên ngoài vào đánh chứ không phải sinh viên của FU. 

Sau đó tôi đã đưa vụ việc này ra công an phường Dịch Vọng Hậu, Quận Cầu Giấy, Hà Nội để giải quyết ban đầu nhóm sinh viên chối tội và đều lôi bằng chứng ngoại phạm ra: có sinh viên thì vào thời điểm xảy ra hành hung sinh viên đó đang ngồi sửa máy cho 1 giảng viên trong trường....? có sinh viên thì có ông chủ phòng trọ làm chứng là vào giờ đấy đang ở nhà. Nhưng cuối cùng bằng biện pháp nghiệp vụ, Nhóm sinh viên đã phải thành khẩn nhận tội, và hứa sẽ không vi phạm. 2 bên đã tiến hành giản hoà. và nhóm sinh viên này bị FU xử phạt, nhưng hình phạt thì tôi không quan tâm, tôi không rõ là cảnh cáo hay kỹ luật trước toàn trường.  

Sau này tôi cũng không quan tâm xem, giảng viên nào làm chứng cho sinh viên đó đang ngồi sửa máy cho họ trong thời gian sinh viên đó đang hành hung tôi. Những tưởng đến đây mọi việc sẽ kết thúc, nhưng đây mới chỉ là khởi đầu cho chuỗi ngày tệ hại đằng sau.

### **II. Hack vào Server trường sửa bài thi để trả thù cá nhân.**

*Sửa bài thi lần 1.*  
Sau khi buổi thi môn Software Quality Assurance and Testing (SQAT). vào buổi tối hôm đó tôi có bật yahoo, và có 1 thằng bạn BUZZ....!
```
YYY : BUZZ....!
YYY : mày làm gì mà để lộ password, tao thấy có thằng nó dùng cái gì đó, nó remote vào nó sửa bài thi của mày.
I : làm gì có nhỷ, chỉ có 1 hay 2 thằng bạn thân biết pass tao thôi, chả lẽ bị lộ ra.
YYY : mày đổi pass đi, tao thấy nó còn bảo là cho mày không ra được trường, cứ thi là nó sẽ sửa bài của mày.
I : thằng nào sửa bài tao thế, có trong list 20 sinh viên hôm trước không?
YYY : đâu đưa cái list tao nhìn mặt cho
I : đưa link ảnh.
YYY : đấy, thằng ở vị trí đấy đấy.
I : ừ tao biết rồi, để lần sau tao đổi pass.
```            

Đến lúc này tôi vẫn tin tưởng rằng Server trường không có bug, vì thằng XXX nó kể LamPT đứng nói ở 1 lớp là: "Sinh viên trường này không bao giờ hack được vào Server trường, bởi vì các em chỉ biết đọc hướng dẫn trên mạng, vậy thì làm sao mà hack được vào Server trường". Lần trước nghe XXX kể thì tôi cũng chỉ cười 1 cái rồi bảo nó: "ông đấy nói thế nghĩa là lão đấy cũng chỉ biết bảo mật theo TUT trên mạng".

*Sửa bài thi lần 2.*  
Nhớ vụ hôm trước bị sửa bài môn SQAT nên trước khi thi 3 ngày, đến trường đổi mật khẩu 1 lần đã. rồi hôm sau đến thi.  
Hôm nay sẽ thi môn Software Requirements (SR). thi xong thấy 1 nhóm lâu la ngồi ở ngoài sảnh tầng 2, toàn các gương mặt bất hảo, cảm thấy có gì đó chẳng lành, mấy hôm sau thấy trượt. thi được có 2.3, trong khi có thằng bạn nó làm kém hơn tôi mà nó được 4,7 -> PASSED (điểm của 2 thằng cuối kỳ đều chỉ cần 4 là PASSED) bắt đầu hoài nghi. nhưng chắc mình tại mình đổi pass trước 3 ngày, nên có khi trong 3 ngày đấy có cái gì mà nó lại có pass của mình. thôi lần sau đổi pass trước khi thi 5 phút cho an toàn. tất cả là lỗi tại mình, trường mình toàn các thầy giáo giỏi, giáo sư, tiến sĩ, nên chắc chắn Server không có bug, lại LamPT code phần mềm thi nên chắc chắn HieuDM không thể hack được.

*Sửa bài thi lần 3.*  
Lần thi lại môn SR. vì lần trước không đủ 4 điểm để qua.  
Trước khi thi 5 phút.
```
YYY : mày đổi pass luôn đi, không tý chúng nó sửa bài thi của mày đấy.
I : ừ, để tao đổi luôn.
YYY : thôi tao đi luôn đây, không bọn nó thấy phiền lắm.
I : ừ, cám ơn mày.
```

Lần này làm bài chắc chắn được 30/60 câu. ít nhất phải được 5 điểm. qua chắc rồi, cười rồi đi về. ra sảnh lại thấy mấy thằng lâu la nó ngồi tụ tập. đoán là quả này nếu teo thì chắc là server trường có bug thật rồi. Chiều về nhà, lên ap.fpt.edu.vn xem điểm được có 2. quả này chắc chắn bị đổi bài.

Tiến hành reverse engineering EOS Client của HieuDM: lấy được email `dohieu1991@gmail.com` của HieuDM sau đó tiến hành login vào email của HieuDM -> lấy được cái ảnh nó sửa bài tôi. Á, à, mình bị nó sửa bài thật rồi -> gọi điện cho thầy Huỳnh Anh Dũng (DungHA). thầy là 1 người có tiếng nói trong trường. gọi điện trình bày toàn bộ vấn đề với thầy -> send mail cho thầy bài thi (file .dat) và file ảnh chứng minh nó edit bài thi của tôi, sáng mai đến trường gặp thầy.

Tối đến dùng 1 vài biện pháp kỹ thuật nghiệp vụ điều tra thêm về HieuDM có vài phát hiện lý thú:  
-  3,4h đêm cu cậu đi xem video hiếp dâm tập thể -> cái này thì tôi hình dung ra cảnh có vài cậu sinh viên ở cùng phòng trọ với nhau, nửa đêm bật lên xem với nhau rồi làm gì thì tôi không biết.  
-  vào ngày: 22 Tháng 12 2011. cậu ta đang tìm cách dùng CCN mua garena shell,buy key kis online, tìm hiểu Mastercard là gì? tìm Zip Code của 1 thành phố ở US. -> cậu này chắc mới vào diễn đàn UG nào đấy, nhặt được mấy con CCN người ta share nên đang muốn sử dụng, và con CCN này đang thiếu Zip Code nên cậu ta đi tìm Zip Code của nó  
-  nhớ lại có lần XXX nói: thằng HieuDM nó bảo là mày chỉ có thể dùng wireshark để tìm ra list sinh viên, bởi vì phần mềm nó đã mã hoá ác lắm rồi, mày không thể nào mà đọc code của nó được.  
Từ 3 điểm này tôi đã hình dung ra cái khoảng trình độ của HieuDM, từ đây giúp tôi khoanh vùng để làm bàn đạp cho tôi tiến hành hack vào Server của FU.

Sáng hôm sau, đến trường gặp DungHA, đang ngồi đợi thì có anh làm bên phòng IT thấy mình rồi hỏi.
```
IT : Hôm trước thầy DungHA có bảo anh xem xét bảo mật Server vì vụ của em, em gửi cho anh 1 số thứ liên quan để anh xem xét chống gian lận, cho anh luôn số điện thoại nhé. (Vụ này là vụ bị hành hung từ đợt EOS Client, chứ không phải vụ hack vào Server edit bài thi)
I : Vâng, email anh là gì?
IT : trungnq@fpt.edu.vn
I : Em gửi rồi nó báo fail anh ạ
IT : Thế thì send cho anh qua email của tập đoàn cũng được
I : Email là gì thế ạ?
IT : trungnq3@fpt.com.vn
I : Em send rồi đấy ạ. (send bản EOS Client của HieuDM, và file Phantom.pcap hôm trước mình capture được)
IT : OK, có gì anh sẽ gọi lại cho em sau. 
```            

Sau này cũng không thấy TrungNQ này liên lạc gì nữa. chắc lão nghĩ tôi cũng chỉ dùng đến wireshark để tìm ra list sinh viên, tôi đoán chắc lão cũng thử resource, nhưng gặp cái Obfuscator của HieuDM nên thôi. sau khi send email này xong, tôi tiến hành thay đổi 1 loạt thông tin của email hack được từ HieuDM, để tránh sinh viên này login vào xoá đi toàn bộ bằng chứng. -> Đổi mật khẩu, đổi câu trả lời bí mật, đổi email forgot password, thay số điện thoại, bật xác minh 2 bước.  
Gặp DungHA, thầy kêu copy lại file .dat của 2 đứa bị sửa bài cho thầy để chấm lại, thầy đi vào miền nam, thầy bảo: "sẽ có người gọi điện cho em để làm việc".  

Ngày hôm sau đi xe máy về Mộc Châu, đang đi đường từ đoạn cây đa bắt đầu dốc Cun (Hoà Bình), đến hết dốc Cun tự dưng trong đầu lại nghĩ về HieuDM và cái server trường. Khi đi gần hết dốc Cun dường như ta đã phát hiện được bug của nó rồi, mà không cần nghiên cứu source -> làm được viêc này nhờ khoanh vùng được trình độ của HieuDM. rồi tôi mỉm cười và đi xe máy về nhà, hi vọng trường sẽ giải quyết tốt đẹp trước khi tôi vào học kỳ mới.

### **III. Ở 1 nơi mà cái "TÔI" của họ quá lớn, và sự vô trách nhiệm đã lên đến đỉnh điểm, thì báo cáo là có bug là chưa đủ. Bạn cần phải hack và quay video thì họ mới chấp nhận hạ bớt cái "TÔI" của họ xuống.**

Vào học kỳ mới, tôi có gọi điện cho DungHA 3 lần, cả 3 lần DungHA đều cười và bảo: sẽ có người gọi điện cho em. Gần hết 2 tuần chờ đợi. Vào buổi sáng thứ 6, ngày này cũng chính là ngày hội thảo TETCON của được diễn ra.
```
I : Con chào thầy ạ, việc kia của con thế nào rồi ạ? Con đợi 2 tuần liền mà không thấy ai gọi cho con thầy ạ.
DungHA : Họ dìm vụ của con xuống rồi.
I : Thế này chắc con phải chuyển vào cơ sở Sài Gòn à thầy? (1 cơ sở của Đại Học FPT tại TP Hồ Chí Minh)
DungHA : Thầy dạy trường này lâu năm, thầy cũng cố hết sức rồi. Nhưng cái "TÔI" của họ to quá. Em phải nghĩ cách khác thôi.
I : Dạ vâng ạ, con chào thầy ạ 
```           

Chạy lên sảnh tầng 2 ngồi. online YH nhờ ZZZ dump cái IT Client bản mới nhất đưa cho, (tôi resource để đọc code được, mà cứ build project thì lại lỗi, nên đành đi nhờ cho nhanh, còn làm nhiều việc khác). nghe đồn hôm qua bắt đầu cho thi bằng bản IT Client mới. Mình nghĩ bụng: "chắc là LamPT fix bug rồi", thế này giờ cứ xem đã rồi sẽ tính tiếp.  

Bật .NET Reflector lên, xem 2 bản mới và cũ khác nhau cái gì, nhìn thấy điểm khác nhau chính: bản mới có thêm phần chụp Desktop và send về Server trường với định dạng JPG, cứ 10s chụp và gửi về Server trường 1 lần. Mình nghĩ bụng: "Chắc là sau vụ của mình báo cáo, trường không thể tìm ra bug và fix được, nên định cho thêm cái hàm này vào, để có gì thì sẽ chấm lại theo mấy cái ảnh chụp được". Liếc qua đoạn này mình thấy sự ngây thơ của LamPT ở 3 điểm chính:  
-  Với cái chiêu send Image về Server thế này thì với 100 hoặc 200 sinh viên thi còn được, chứ vào trường suốt kêu là sẽ đào tạo hàng chục nghìn sinh viên vậy chính LamPT đang yêu cầu các sinh viên thành Zombies và tấn công flood vào hệ thống Server thi của FU.  
thực hiện phép tính: có 1000 sinh viên thi. dung lượng 1 file JPG khoảng 100kb vậy cứ 10s Server trường sẽ hứng: 1000 \* 100KB = 100 MB -> 1s Server trường sẽ nhận 10MB -> LamPT đang tiến hành flood vào Server trường với băng thông là 10\*8= 80 Mbps

Với số lượng sinh viên ít còn được, chứ nếu đông lên chắc là server trường die. Ngoài ra nếu mục đích của LamPT là để Monitor màn hình sinh viên xem sinh viên đó có gian lận không thì  
-  LamPT đã phá sản lần 2. sinh viên đó chỉ cần tránh các điểm thời gian mà chia hết cho 10. thì sẽ không bị phát hiện. Trước đây tôi thấy có cậu bạn học tại FPT Aptech mấy quyển sách của cậu ta có slogan của Aptech, tôi không nhớ chính xác nhưng nội dung nó cũng đại để là: "Chặn đầu công nghệ chứ không đuổi theo công nghệ". việc này tôi thấy chính LamPT đang bò theo công nghệ chứ không phải đuổi theo.  
-  HieuDM đã có thể sửa được bài thi của sinh viên (file .dat) ở trên Server thì mấy cái ảnh này cậu ta thích thì cậu ta lại sửa nốt. rất ngây thơ, chả có tác dụng gì cả.

Tiếp tục nhờ dùng ý tưởng hôm trước khi đang đi xe máy về Mộc Châu, tôi chỉ mất khoảng 5 phút để code ra 1 phần mềm giúp tôi tiến hành sửa bài thi của các sinh viên tại server FU. Công việc còn lại của tôi là đợi có 1 lớp nào đó thi rồi tiến hành hack vào sửa bài của 1 sinh viên. Rất dễ dàng để có được Exam Code của 1 môn thi, ngoài ra để đảm bảo mình luôn là chính nghĩa, không phải phá hoại ai, tôi đã liên lạc với 1 sinh viên để lấy Exam Code và trình bày sự việc với cậu ta + xin phép sửa 2/40 câu trong bài thi của cậu ta. cũng chỉ 0.5 điểm. không ảnh hưởng lắm, ngoài tra tôi có đề cập với sinh viên này là sẽ gửi đoạn video tôi hack để cho trường fix bug này và sử lý nhóm HieuDM.

Sau đó tôi đã tiến hành hack vào Server FU và quay video lại đồng thời buổi chiều hôm đó đã đưa video cho Ban Giám Hiệu của FU, và có buổi nói chuyện. Trong buổi nói chuyện có 4 người: Tôi, DungHA, PhongNX, và cô hiệu phó Nguyễn Kim Ánh (AnhNK) cuộc nói chuyện dài khoảng 45 phút đồng hồ. Với nội dung chính mà từng người muốn đề cập.
```
AnhNK : Nếu thế thì bây giờ tạm thời cứ cho em sinh viên này thi bằng giấy, để cho nhóm sinh viên kia không thể hack vào server sửa bài của em sinh viên này.
DungHA : đấy em đã nói rồi, Server trường có bug mà, phải dừng mọi việc thi cử trên máy ngay để bao giờ fix được bug thì mới thi tiếp được. thằng này nó học thật, không làm được thì nó thôi, mấy lần em dạy nó em biết. bây giờ bọn kia hack vào Server sửa bài thi của nó, hôm trước em lấy file .dat của nó nộp lại cho em, đưa cho cái Nga chấm lại, cả 2 bài của nó khác hoàn toàn với bài trên server, và đều thừa điểm qua. trường phải xem lại thôi, chứ 2 năm nay server trường không có bảo trì gì cả, có khi bây giờ bị chúng nó cài đầy Backdoor lên đấy rồi.
AnhNK : Nhà trường sẽ ghi nhận vấn đề này, em có ngại đứng ra nói không?
I : Em sẵn sàng đứng ra trước hội đồng của trường và toàn thể sinh viên của trường cũng được, nếu như trường trả lại đúng điểm thi của em và sinh viên kia, (tức là mình và sinh viên kia đủ điểm để PASS môn SR) và trường xử phạt sinh viên HieuDM cùng toàn bộ nhóm sinh viên gian lận mà em có được danh sách.
AnhNK : Được em ạ, miễn là em chứng minh được với trường. Phần mềm nào cũng phải có lỗi em ạ, và đều phải test trước khi sử dụng, đây cũng coi như là 1 lần test và em là tester đã tìm ra lỗi. sinh viên trong trường cũng bảo mật và tìm lỗi giúp nhà trường.
I : vâng ạ
PhongNX : Tại sao em lại nói là sinh viên HieuDM gian lận, và làm sao em lấy được list sinh viên gian lận?
I : Tại lần trước có vụ việc HieuDM cùng 1 nhóm sinh viên có hành hung em, vụ đấy trường cũng biết rồi đấy ạ. Ở trường thì thường có các nhóm sinh viên gian lận chơi với nhau, và chỉ những sinh viên trong nhóm mới có được phần mềm gian lận, những nhóm này thường hoạt động theo kiểu private share nên rất khó điều tra. Nhóm sinh viên HieuDM cũng không phải ngoại lệ, để chắc chắn rằng phần mềm của mình không bị dò dì ra bên ngoài chỉ có thành viên trong nhóm mới được sử dụng nên sinh viên HieuDM có chèn thêm 1 đoạn code để tự động gửi thông tin của những sinh viên sử dụng phần mềm này về email của mình. em có tiến hành các kỹ thuật và chiếm được quyền quản lý email này của sinh viên HieuDM vì thế nên em có thể có đầy đủ list sinh viên gian lận.
PhongNX : được rồi, thứ 2 tuần sau họp giao ban, nhà trường sẽ họp và xử lý việc này.
I : vâng ạ, (Chào và đi về). 
```            

Tối về chat với ZZZ.
```
I : Ừ, chiều nay tao gặp BGH trường rồi -> kể lại tình hình với nó
ZZZ : Bug khá nguy hiểm
I : Ừ, cái đoạn "2 năm nay Server trường không có bảo trì gì cả" tao cũng shock mày ạ
I : Nếu thế thì bây giờ tạm thời cứ cho em sinh viên này thi bằng giấy, để cho nhóm sinh viên kia không thể hack vào server sửa bài của em sinh viên này. -> À hoá ra chỉ cần tao không bị sửa bài là được, còn lại đứa sinh viên nào khác bị sửa bài thì trường kệ. 
```            

Tối đi ngủ để hôm sau lại phóng xe máy 200 Km để về Mộc Châu ăn tết. Nhưng mình vẫn cảm thấy có cái gì bất ổn, vì lần trước báo cáo thế trường không thèm làm việc phải hack vào server trường rồi quay video lại thì mới được nhìn thấy mặt của 2 thầy cô trong BGH.

### **IV. Không đối thoại, không gặp mặt, coi như chưa từng có gì xảy ra.**

Ăn tết xong, háo hức chờ đợi từng ngày, chờ đợi được nhà trường gặp mặt để xử lý công việc này. Với mình thì thiệt hại 1 lượt đi từ Hà Nội đến Mộc Châu - 200Km, tiền ăn ở 3 ngày dưới Hà Nội, nhưng không sao. Cứ xử lý vụ này xem nào. HieuDM lần trước cùng 1 loạt sinh viên hành hung mình rồi, chưa đầy 2 tháng lại tiếp tục làm vụ này. chắc là quả này đuổi học là nhẹ nhất. ngoài ra nếu làm đúng thì hoàn toàn có thể bị truy tố trách nhiệm hình sự. Và tất nhiên tôi làm việc này là vì toàn bộ sinh viên của trường, trong 3 năm nay không biết đã bao nhiêu sinh viên dựa vào đây để gian lận? bao nhiêu sinh viên đã bị sinh viên khác sửa bài và bị mất tiền bạc và công sức để học lại? Rồi sau vài năm nữa, liệu sẽ có thêm bao nhiêu HieuDM? và tôi quyết định rằng phải làm hết sức và yêu cầu trường fix bug này, vì không thể để 1 bug như thế này tồn tại ở server của trường. Tết xong vào học được 3 ngày thì nhận được Email:
```
2012/2/1 Huynh Anh Dung <dungha@fpt.edu.vn>
            
Con gởi cho thầy tất cả java file client exam để thầy coi trưa nay rảnh qua gặp thầy

Mr. Huynh Anh Dung
FPT University,
8, Ton That Thuyet, Cau Giay Hanoi, Vietnam 
```            

Sau đó tôi gọi cho DungHA để thông báo về việc đã gửi email. Thi thấy DungHA nói là đang làm việc với Trưởng phòng đào tạo Sau này tôi và XXX cũng thắc mắc là tại sao trong email này DungHA lại nói đến "java file client exam". mặc dù phần mềm thi gốc của LamPT và bản tôi code trong video đều dùng C# .NET. vì thế nên tôi đã send Collection.rar cho DungHA Vào ngày 07-02-2012, tôi có chủ động gặp DungHA
```
I : Vụ kia thế nào rồi ạ thầy?
DungHA : Con không phải lo đâu, đã có thầy làm rồi.
I : Trường có cần thêm thông tin nào nữa không ạ? Có cần con chiếm thêm quyền cái hotmail của HieuDM để cung cấp thêm bằng chứng không ạ?
DungHA : (Cười) Không cần đâu, đủ rồi, cứ để thầy làm cho.
I : Vâng ạ,Thế bao giờ có kết quả ạ thầy?
DungHA : Thứ 6.
I : Vâng ạ, con chào thầy ạ 
```            

Ngày 10-02-2012. Tôi có gọi điện và hẹn gặp trực tiếp DungHA vì hôm nay là ngày hẹn có kết quả.
```
I : Con chào thầy ạ, vụ kia của con như thế nào rồi ạ thầy?
DungHA : Con và thằng kia sẽ được thi lại trên giấy vào cuối kỳ này.
I : Thế còn nhóm sinh viên kia thì sao ạ?
DungHA : Chúng nó không sao cả.
I : Thế đống Log trên server thì sao ạ?
DungHA : Không bắt được tận tay thì không làm gì được nó cả.
I : Vâng ạ, con cám ơn thầy ạ. (Đến đây tôi cũng hiểu rằng thầy đã cố hết sức rồi, cái trò bắt tận tay này chắc là của BGH ở cái hội đồng kia rồi, vậy là họ không thèm gặp mình). 
```            

Vâng, và đến đây thi kết quả ngoài sự mong đợi của tôi rất nhiều. 

Từ 1 công thần: Tìm ra list sinh viên vi phạm, báo cáo bug với nhà trường thì mình đã biến thành cái gì thế này? theo như lần gặp chiều thứ 6 trước tết thì bài thi của mình đủ điểm qua rồi, tại sao lại bắt mình phải thi lại? nếu thế thì trường đang coi thường danh dự của trường. trường chà đạp lên quyền lợi của sinh viên.  

Bây giờ trường cho tôi và sinh viên kia thi trên giấy, chắc là trường không fix được bug rồi. biết hệ thống có bug, sinh viên demo 1 video đưa cho xem, thế mà vẫn không fix được? Cách làm việc thật vô lý (Và sau này, tôi phát hiện ra 1 sự không ăn khớp trong cách làm việc của trường, dường như trường trao quyền hành cho 1 vài người, và nhận báo cáo từ 1 số người này, vận nên mấu chốt của vấn đề sẽ là ở 1 số người này, chứ không phải ở BGH của trường, vì BGH chỉ nghe báo cáo từ những người này, chứ không biết tình hình thực tế)

Tối hôm đấy về chat với ZZZ.
```
ZZZ: kết quả?
I : tao với thằng kia phải thi lại trên giấy.
ZZZ: kết quả này đã nằm trong dự đoán, thế bọn kia sao?
I : không sao cả, trường kêu log trên server không làm gì cả. phải bắt tận tay mày ạ.
ZZZ: bắt tận tay với dân CNTT khó như với trăng.. Alt-F4 hay 1 phím tắt nào đó thì có mà bắt tận tay
I : ừ, trường nó nói thế thì mấy vụ hack ở trên internet làm sao FBI, CIA bắt tận tay được, sao nó vẫn điều tra được và xử lý. nói chung là quả này quay lưng lại với toàn bộ sinh viên của trường rồi. tao không biết nhóm HieuDM có cái gì hay có "cây đa", "cây đề" nào mà chúng nó chắc chân thế. chứ như thằng khác hoặc như tao 1 cái là trường đuổi học lâu rồi, vớ vẫn còn 2 tay đeo 2 đồng hồ.
```            

### **V. Các thông tin xung quanh.**

1.  Ở bản EOS Client thì không hiểu do vô tình hay cố ý mà LamPT lại send cả đáp án về cùng câu hỏi. Ở bản EOS Client - Edited Version của HieuDM, cậu ta đã lợi dụng điều này để Mod lại bản của LamPT, sinh viên nào sử dụng bản của cậu ta khi đăng nhập vào thì phần mềm sẽ tự động làm hết toàn bộ. -> điểm thi sẽ là 10. sinh viên sẽ phải Edit bài làm đi, để còn khoảng 8.x hoặc 9.x để tránh trường nghi, nếu có sinh viên nào mặt dầy thì chắc là sinh viên đó sẽ được 10 mà không cần phải biết gì cả.
2.  Update ngày 14/02/2012: [http://cms.fpt.edu.vn/?p=21927](http://cms.fpt.edu.vn/?p=21927)  
    Đây là tại cơ sở 2, dành cho sinh viên chuyên ngành Quản trị kinh doanh và Tài chính ngân hàng, trước đây học cùng bên Detect nhưng do đông quá không đủ chỗ nên đã tách ra thuê mặt bằng ở gần khu sân vận động Mĩ Đình, Nếu thi tiếng anh thì là sử dụng bản EOS Client, vậy là bên này đã có thêm 1 HieuDM hay là sản phẩm của đệ tử HieuDM. và cách giải quyết của nhà trường là do máy sinh viên bị virus? Vậy có 1 người code 1 con Virus rồi lừa các sinh viên copy usb để khi sinh viên làm bài thì bài trên Server bị thiếu, và khác hoàn toàn với bài làm của sinh viên? Và từ Server trường có bug, họ đẩy cái lỗi sang là tại máy tính sinh viên có Virus....? 1 cách đá bóng không thể nào hay hơn  
    Thông báo trên ap.fpt.edu.vn đổ lỗi cho máy tính của sinh viên bị Virus -> [http://farm3.anhso.net/upload/20120215/22/o/anhso-225721\_FSB\_Hacked.jpg](http://farm3.anhso.net/upload/20120215/22/o/anhso-225721_FSB_Hacked.jpg)

Bình luận trên facebook của vài sinh viên trong trường chưa biết việc Server trường bị hack nói về việc này -> [http://farm3.anhso.net/upload/20120215/22/o/anhso-225724\_FSB\_in\_fb.jpg](http://farm3.anhso.net/upload/20120215/22/o/anhso-225724_FSB_in_fb.jpg)

Vậy cái cách làm việc của FU là thế này:

*   Fri, Dec 23, 2011: Tôi báo cáo Server có bug -> Trường vẫn không tìm được bug, và không tiến hành fix. Họ coi thường không thèm gặp sinh viên để tìm hiểu về bug
*   Fri, Jan 13, 2012: Tôi chính thức gửi video demo hack vào Server trường -> Trường mới chịu thừa nhận mình có bug, và bảo sẽ họp để xem xét
*   Wed, Feb 14, 2012: Có hiện tượng cơ sở FSB bị hack vào sửa bài của sinh viên khác, thì trường đổ lỗi cho máy sinh viên có virus (Những sinh viên bên này thi trước ngày 14-2. chắc do điểm thấp nên báo cáo kết quả, đòi phúc thẩm hay như nào đó) và theo báo cáo của tôi, thì trong ngày 14-2 đã có bản IT Client mới: `IT_Client_14_Feb_2012.rar` giải nén ra trong chứa folder: `EOS_IT_Client_Release_14_Feb_2012`.

Vậy là cách làm ở đây là để đảm bảo uy tín và danh dự của trường thì:

*   Trường sẽ coi như không có vụ HieuDM
*   Đổ lỗi tại máy sinh viên bị virus. có con virus nào được code để chính bài thi của sinh viên ngay tại máy sinh viên? và trường âm thầm cập nhật thêm bản vá lỗi.Nếu những sinh viên bị sửa phải học lại, thì thiệt hại sẽ vào khoảng từ 50->100$ (tiền học lại 1 môn)

Trong thời gian 3 năm gần đây, IT Client có nâng cấp, nhưng không phải về bảo mật mà chỉ là về góc độ chống sinh viên gian lận.

*   Version 1: được Set always on top, nhà trường quảng cáo là các em sẽ không thể vào mạng internet khi đang thi -> Sinh viên by pass: dùng các phần mềm hỗ trợ set firefox, IE always on top
*   Version 2: để chống sinh viên by pass. thì IT Client được set forgein backgroud mỗi giây 1 lần. -> Sinh viên by pass: Dùng Desktops.exe để bật sang Desktop khác. vẫn có thể sử dụng firefox, IE bt
*   Version 3: khoá hết bàn phím và chuột, mỗi ngày build 1 bản, để có phần chữ đỏ khác nhau, tránh sinh viên code lại IT Client. -> Có sinh viên báo cáo bị hack sửa bài thi.
*   Version 4: 10s send 1 Image chụp màn hình sinh viên về Server để monitor.... or DDoS Server trường?

Các mục sinh viên by pass chỉ là để dành cho các sinh viên không có khả năng về Hacking, dùng những kỹ thuật đơn giản để gian lận.

Khi tôi bị hack thì phát hiện được version mới nhất vẫn còn bug? Vậy trong 3 năm nay, đã bao nhiêu sinh viên gian lận bằng cách hack vào server trường sửa bài thi? Đã bao nhiêu sinh viên bị sinh viên khác sửa bài thi để cho học lại? Vậy mà FU vẫn làm ngơ? Vậy nếu không có vụ HieuDM sửa bài thi của tôi thì liệu sự việc này, sẽ còn tồn tại trong bao nhiêu năm? Đã có bao nhiêu HieuDM rồi và sẽ có bao nhiêu HieuDM nữa? Cách hành xử của FU như thế nào? Tại sao có những cái là do phần mềm của nhà trường có bug, bị attacker tấn công vào server trường, thì trường lại đá bóng sang, đổ tại: "máy sinh viên bị nhiễm virus"? Liệu danh dự và uy tín được xây dựng trên nền tảng giả dối có đáng không?

Tổng kết công việc đã làm:  
RE Tool gian lận của HieuDM -> chiếm được cái email: `dohieu1991@gmail.com`. --> Giống với việc anh TQN RE malware STL lấy được email bọn này (tất nhiên thì trình độ không thể bằng 1% của anh TQN) -> không có phạm tội gì cả.  
1 lần hack vào server trường sửa bài thi của 1 sinh viên, nhưng đã nói trước với sinh viên kia + quay video lại đưa cho trường đầu tiên để báo cáo bug -> mục đích xây dựng -> không có phạm tội gì cả. ​

Tôi cũng chỉ là 1 thành viên bình thường của hva, nên đừng có nhà đài nào nói là: *"Thành viên HVA hack vào server của 1 trường đại học"*, nói thế oan cho HVA lắm. Dạo trước tôi hay chơi DotA, nên hay sử dụng những từ ngữ của các room DotA public. Vụ việc lần trước có nhóm sinh viên HieuDM có lên facebook và chửi nhau với tôi, 2 bên đều có những lời lẽ rất thô tục Tuy nhiên do đây là chủ địch của nhóm này nên sau khi đợi tôi dính bẫy họ đã nhanh tay xoá hết các bài viết của họ, và chụp ảnh lại những lời nói của tôi nên nhìn có vẻ hơi phảm cảm. Theo như thoả thuận sau khi hoà giải phía công an phường Dịch Vọng Hậu - Quận Cầu Giấy - Hà Nội thì nhóm này sẽ xoá page này đi. tuy nhiên nhóm này lật kèo và để lại nhằm mục đích bêu xấu tôi. Tuy nhiên điều đó không quan trọng, điều quan trọng ở đây là: "Đừng quan trọng quá khứ tôi là ai. hãy nhìn vào những việc tôi đang làm" Trích từ: V for Vendetta

Khi viết bài lên hva tôi đã cố gắng chỉnh sửa từ ngữ rất nhiều và cố gắng viết sao cho đầy đủ nhất,cho người đọc toàn cảnh mà tôi thấy trong thời gian qua, nên đôi khi bài viết có thể dài dòng. tuy nhiên theo tôi đó đều là những thông tin cần thiết. (tôi đã mất 1 tuần để chỉnh sửa câu chữ cũng như bỏ bớt những nội dung không cần thiết) Hiện tại thì tôi đã tạm dừng toàn bộ các học phần của học kỳ này tại FU để cho thoải mái tinh thần sau 1 kỳ học quá nhiều căng thẳng. chiều chiều vẫn ra ngồi uống trà đá nhìn dòng người đi lại có chút cảm giác yên bình. Sang học kỳ sau tôi sẽ tiếp tục đi học bình thường tại FU.
```
ZZZ : dù gì thì mày vẫn lệ thuộc vào trường
ZZZ : làm to chỉ có nước bỏ trường rùi làm to
I : không phải tao đang phụ thuộc trường
I : mà tao lại sợ không dám làm to
I : tao cứ làm to, rồi kỳ sau tao lại đi học bình thường.
I : còn tao làm to thế này chỉ động chạm đến 1 số cá nhân, chứ không phải tao động chạm cả trường.
I : không thể vì có gì đó với 1 số cá nhân và 1 số sinh viên mà lại phải bỏ trường
ZZZ : mày làm to lại quay về học
ZZZ : thì không biết là khôn hay ngu nữa
I : đấy là mày nghĩ mày khôn nên mày không làm to
I : còn tao thì tao nghĩ trường không thể chơi cái trò vô trách nhiệm đấy được.
I : chỉ có thằng nghĩ mình khôn mới im đi để cho xong rồi ra trường.
I : tao cứ làm to đấy, xem tao sai gì? xem trường làm gì tao? hay 1 số cá nhân nào làm gì tao ​
```           

Nếu như các bạn đừng ở góc nhìn của tôi thì các bạn sẽ thấy ở FU: các môn IT, lợi dụng bug server để lấy điểm cao, thậm chí toàn 9,10. còn môn BE thì có thể được 10 luôn. Chỉ cần học tiếng nhật 1 chút thì các bạn có thể được cóc vàng (sinh viên có điểm tổng kết tất cả các môn cao nhất toàn trường). Vậy nếu nhìn ở góc độ này thì này các sinh viên đang tranh nhau gian lận để kiếm cóc vàng. tôi thấy nó giống như việc bầy khỉ đang tranh nhau một cái mũ rách. Tôi viết lên đây cũng để cho mọi người thấy được rõ những thứ tôi thấy trong thời gian ngắn qua. Chính FU cũng cần phải thay đổi lại mình, để còn phát triển hơn nữa. Cần phỉa có 1 cuộc thay máu mạnh mẽ, chứ không thể chạy lâu dài và mạnh mẽ với một bộ máy kiểu này.

Tôi thấy BGH FU giống như ông vua trong truyện ông vua và bộ quần áo mới. Với cái bug này thì các đại thần ai cũng coi mình là người thông minh nên phủ nhận coi như không có, đến lúc đưa video cho thì hành xử kiểu coi thường, không liên hệ cẩn thận để nghiên cứu cách xử lý? vậy thì những ông vua này định mặc những bộ quần áo mà chỉ kẻ thông minh nhất mới nhìn thấy đến bao giờ? Cần phải chém đầu 1 số đại thần đi. thì những ông vua này mới quản lý tốt được, mới không phải mặc những bộ quần áo như thế nữa.

### **3\. Cập nhật 1 vài thông tin mới nhất.**

Thu, Feb 16, 2012:  
Tôi có email cho DungHA để nói về việc tình trang bên FSB thì 08:16 Fri, Feb 17, 2012, tôi có nhận được 1 cuộc điện thoại của DungHA bảo qua trường gặp, và DungHA bảo tôi là trường mới ra bản IT mới nhất, và hỏi tôi đã xem qua chưa? sau đó tôi có SMS trả lời với nội dung chính là: "Tôi đang ở Mộc Châu nên không thể qua trường, tôi email chỉ là để hỏi ý kiến của DungHA về cách hành xử của trường, tôi quá mệt mỏi với việc chiến đấu chống nhóm HieuDM gian lận và phá hoại". Và hiện tại thì tôi cũng không có hứng hack vào server trường. lần trước hack vào là mang tính chất để khai báo bug, và để xử lý nhóm sinh viên HieuDM, nhưng theo DungHA nói thì thôi, giờ hack chả được gì, khéo trường lại đuổi học vì tội hack vào server trường thì khổ. Còn nếu xét trên góc độ tester thì tester này ăn cơm nhà vác tù và hàng tổng?

Fri, Feb 17, 2012:  
Tôi có email cho cô hiệu phó AnhNK để hỏi về cách xử lý của nhà trường về vụ HieuDM, thì có nhận được trả lời là:
```
Chào em,  
Về việc này trường đã đề nghị Ban đào tạo sớm tổ chức họp, tìm hiểu kỹ các vấn đề, trao đổi với các thày và báo cáo trường.  
Hiện đang đợi kết quả làm việc của Ban đào tạo em ạ.  
AnhNK ​
```        

\-> Tôi cũng không thể hiểu được cách làm việc của FU, DungHA thì bảo là nhóm HieuDM không bị sao cả, còn AnhNK thì lại bảo là đang đợi kết quả của Ban đào tạo. Từ đây cho tôi thấy cách làm việc không ăn nhập của trường. Hoặc có thể 1 vài ông đại thần đã sử lý rồi, và tất nhiên không dám báo cáo với ông vua, mà cứ khất lần rồi để lâu cho những ông vua quên đi. Những miếng cơm hàng ngày mà những "Đại thần" đút vào miệng họ và gia đình họ là tiền đóng học của toàn bộ sinh viên FU, chứ không phải chỉ là của 1 vài sinh viên. Hay là có những sinh viên và nhóm sinh viên đưa ra những miếng thịt? Và nếu họ có đưa những miếng thịt thật, thì họ cũng chỉ đưa đưa được cho 1 vài người, chứ không có thể đưa miếng thịt cho tất cả những người vào Internet để giấu chuyện này đi.

Cùng ngày Fri, Feb 17, 2012: tôi có gửi 1 email đến hiệu trưởng Lê Trường Tùng(TungLT) để hỏi xem TungLT có biết gì về vụ việc này không, nhưng hiện tại đến ngày Sat, February 18, 2012 tôi chưa nhận được phản hồi. Chắc là thầy chưa vào email, hoặc do thầy quá bận. Việc khen thưởng kỷ luật hình như là thuộc công việc của PhongNX, và PhongNX làm về mảng IT. Tuy nhiên vì 1 vài lí do riêng nên tôi không email hay liên lạc với PhongNX.

*Hết phần 1*

|


# Đại học FPT (Phần 2): Phần chìm của tảng băng trôi

*Lấy từ nguồn* `https://voz.party/d/124633-dai-hoc-fpt-phan-2-phan-chim-cua-tang-bang-troi/` (old voz)

* * *

Trước khi đọc bài viết này, các bạn có thể đọc phần 1:  
\-> Đại học FPT: khi sinh viên gian lận và hack vào server trường. Tại địa chỉ [http://www.hvaonline.net/hvaonline/posts/list/0/41260.hva](http://www.hvaonline.net/hvaonline/posts/list/0/41260.hva)

Trước tiên là xin thứ lỗi vì đã im lặng quá lâu trong thời gian vừa qua vì tôi bận thu thập thêm vài thông tin và bằng chứng để có thể có được 1 bài viết hoàn chỉnh nhất để gửi tới tất cả các độc giả của tôi.

1 Vài chú ý trước khi đọc phần 2:

*   Sau khi đọc phần 1 rất nhiều độc giả phản ánh về cách viết các nhân vật trong bài viết của tôi (Những độc giả này chủ yếu là các sinh viên đại học FPT, và những người muốn tìm lỗi để hạ thấp bài viết của tôi) chủ yếu ở việc mình viết "DungHA". Ở đây những người này nói tôi gọi thầy giáo theo cách chống không??? Là hành động vô lễ, ăn nói "bố láo"??? Nhưng trong bài viết tại phần 1, tôi đã viết "gọi điện cho thầy Huỳnh Anh Dũng (DungHA)". Do bài viết dài nên các đoạn sau tôi viết ngắn gọn khi nhắc đến tên thầy Huỳnh Anh Dũng là DungHA. Vì vậy khi đọc bài viết các bạn có thể hiểu DungHA là Thầy Huỳnh Anh Dũng. Đừng cố tìm 1 lỗi nhỏ để phủ nhận giá trị bài viết của tôi và hạ thấp tôi. Thống nhất là thế nhé, Nếu các bạn cảm thấy không có thể đọc được kiểu này thì hãy nhấn "Ctrl + H" -> 'DungHA' ===> 'Thầy Huỳnh Anh Dũng'. Nếu không có thể làm như thế, các bạn có thể close tab này lại và không đọc bài viết của mình nữa. Để tránh mất thời gian của các bạn và tôi không cần các độc giả như thế.

*   Mình luôn hoan ngênh các ý kiến phản hồi từ các bạn, các bạn có thể thoải mái phản biện tại HVA, vì HVA là 1 diễn đàn hoạt động đề cao dân chủ. Những bài viết dạng troll, hay muốn phá hoại topic thì các moderator nếu không thoải mái có thể ẩn đi, delete bài viết, chứ không nên vì 1 số bài viết này mà close cả topic của tôi.  
    Sau đây nếu chấp nhận các điều trên các bạn có thể đọc tiếp bài viết của tôi.

Nếu các bạn đã đọc phần 1, thì mình sẽ nói qua về việc điều tra, phá án vụ việc vừa rồi.  
Download toàn bộ tài liệu liên quan (bao gồm toàn bộ các tài liệu bên dưới):
```
http://ubuntuone.com/6q7dgeBS4OccoNxDVUlS71
or http://www.mediafire.com/?ilarwzi86wm2mgp
```            

pass giải nén: `hvaonline.net`

20 Feb 2012:  
Liên lạc với phía tập đoàn FPT , bên phía tập đoàn FPT sau khi họp bàn có cử 1 anh Điều Tra Viên đẹp trai (ĐTV, từ đây khi tôi viết ĐTV tương đương với "anh Điều Tra Viên đẹp trai") gặp mặt và nói chuyện với mình cũng như bàn bạc về cách giải quyết công việc. Ở đây tôi và ĐTV đều thống nhất là khi giải quyết sẽ "trọng chứng" hơn "trọng cung", vì bây giờ mỗi sinh viên có thể khai 1 kiểu nên làm viên sẽ coi trọng bằng chứng hơn. Ngoài ra ĐTV có nói thêm là để tránh bị loãng thông tin và gây khó khăn cho việc điều tra nên sẽ không tham gia thảo luận tại internet nữa. Sau đó ĐTV có ý muốn close topic tại hva và voz. Tôi đã đồng ý với ĐTV là sẽ close topic tại 2 forum lớn này để điều tra.

Lúc này tôi bắt đầu chào tạm biệt ĐTV và đi về nhà. Sau khi về nhà tôi liền tiến tới laptop của mình (bật 24/24) và quan sát tình hình: Chủ đề của tôi thấy bài viết cuối cùng là của 1 Moderator KKK, sau khi click vào thấy bị lock, bài viết cuối cùng là của gamma95. Tôi nghĩ bụng: "quái lạ, topic bị lock rồi mà lão gamma95 vẫn post được thêm 1 bài", liếc lại thì thấy bài viết gamma95 đã được viết từ vài phút trước, F5 vài cái thì thấy topic lại open ra => À há, cái này là do Moderator KKK (làm việc dưới quyền ĐTV) không hiểu ý sâu xa ĐTV nên vội vàng đăng bài rồi close topic, ý của ĐTV chỉ là nói chuyện với tôi và tôi đồng ý close topic rồi sau đó sẽ liên lạc với 1 Moderator khác để close cho khách quan. Nhưng KKK không hiểu ý nên đã vội vàng đăng bài thông báo close và close topic. Nên chắc chắn ĐTV đã "hạ lệnh" cho KKK xóa bài viết đi và open topic lại, sau đó sẽ liên lạc cho 1 Moderator khác để close topic lại cho mọi người bên ngoài thấy "khách quan". 1 lúc sau đúng như tôi dự đoán đã có 1 Moderator khác vào đăng bài để close topic. Từ đây tôi nhận thấy ĐTV là người rất có kinh nghiệm và khả năng và rất chắc chắn, nên nếu ĐTV đã quyết định điều tra thì có thể hoàn toàn có thể điều tra ra được sự việc. Tôi nghĩ rằng nếu ĐTV mà muốn chuyển sự việc theo hướng khác thì tôi cũng không thể làm gì được.

Việc close topic trước đã được tôi đồng ý nên tôi không thắc mắc gì. Tuy nhiên tại topic này thì tôi sẽ không bao giờ đồng ý cho bất cứ Moderator nào close topic của tôi vì bài viết của tôi hoàn toàn tuân thủ nội qui của diễn đàn, tôi hoàn toàn có đủ kinh nghiệm sau lần 1 để nếu có hợp tác cùng ĐTV điều tra thì sẽ không để topic này làm ảnh hưởng đến công việc điều tra. Và điều quan trọng nhất tôi nói đến đây là hvaonline.net chứ không phải 'fpt'online.net, nên không thể có chuyện 1 "ai đó" liên lạc với 1 Moderator vừa nhận chức là có thể close được topic của tôi.

Trong những ngày này tôi có hợp tác với ĐTV để cung cấp thêm 1 vài thông tin và bằng chứng để điều tra. Trong thời gian này tôi và ĐTV cũng có mâu thuẫn về việc sẽ xử lý HieuDM. Tôi có yêu cầu nếu điều tra được thì sẽ đuổi học HieuDM. ĐTV với lòng vị tha vẫn bảo tôi là nếu HieuDM biết hối cả chịu nhận tội thì sẽ kỷ luật nặng rồi vẫn cho học tiếp vì HieuDM là người tài, tuổi còn trẻ, dễ vấp ngã nên cho HieuDM 1 cơ hội để sửa sai. Trước khi đến giây phút cuối cùng để tiến hành xử lý các sinh viên phạm tội thì tôi sẽ vẫn hợp tác cùng ĐTV để điều tra

24 Feb 2012:  
Có cuộc họp tại FU gồm: Hiệu Phó Nguyễn Xuân Phong (PhongNX), thầy Phan Trường Lâm (LamPT) + 1 vài nhân viên khác tại FU, theo 1 vài nguồn tin thì ông Trưởng Phòng Quản Lý và Đào Tạo FU đã tự ý bỏ về trước không dự buổi họp này(Sau này tôi sẽ bàn luận thêm về việc làm của nhân vật này), và đại diện của tập đoàn FPT là ĐTV. Sau đó hội đồng này gọi từng sinh viên vào 1 để tiến hành "hỏi cung"  
Cuộc họp diễn ra với nội dung chính thu thập được:

*   "Bùi Trần Thanh Huyền" khai là không nhớ cho ai mượn máy tính của mình (Đây là chủ nhân của mày tính có ComputerName: JETJARI-PC). Khi ĐTV hỏi máy tính đang ở đâu thì nói vòng vo rồi không giao máy tính ra.
*   "Nguyễn Tiến Hùng" có xác nhận về việc copy phần mềm gian lận từ HieuDM (bản EOS mà tôi đã tiến hành dùng wireshark capture được ra list 20 sinh viên gian lận và lấy được email ).
*   "Nguyễn Trung Đức" có xác nhận là có sử dụng phần mềm gian lận để thi cuối kỳ , ngoài ra khai thêm 3 sinh viên sửa bài môn SQAT của tôi: Nguyễn Đức Tiến , Bùi Trần Thanh Huyền , Phạm Minh Hải  

Đáng chú ý nhất là cuộc "hỏi cung" Phan Lê Việt Anh (aka phanledaivuong)  
Sau khi làm rõ được một loạt thông tin như tôi lấy phần mềm từ XXX (Phạm Đức Anh - AnhPD01069) và 1 vài thông tin thì có thêm 1 vài câu hỏi đáng chú ý của PhongNX với tôi với nội dung chính như sau:
```
PhongNX: Em nói là bạn Nguyễn Lâm Hùng (HungNL) đồng ý cho em sủa bài?  
Tôi: Vâng, bạn HungNL đồng ý cho em sửa bài của bạn ý.  
PhongNX: Nhưng mà bạn ý nói với thầy là bạn ý không đồng ý?  
Tôi: Bạn ấy nói với em là bạn ý đồng ý cho em sửa bài.  
PhongNX: Thế tại sao bạn ý lại nói như thế với thầy?  
Tôi: (Nghĩ bụng: Thằng Hùng nó thích nói gì với thầy là việc của nó, nó nói gì với em là việc của em, sao thầy hỏi thế thì em trả lời kiểu gì? Thôi thì không biết trả lời kiểu gì thì đành hỏi lại thầy 1 câu xem thầy trả lời câu hỏi của mình thế nào.) Nếu bạn ý không đồng ý tại sao bạn ý lại gửi Exam Code cho em?  
PhongNX: !!!
```           

Trước đó HungNL có gửi email kèm bản tường trình sau gửi cho PhongNX. Sau đó PhongNX đã gặp trực tiếp HungNL và đã in bản tường trình này ra. Ngoài ra còn yêu cầu HungNL viết thêm 2 dòng với nội dung chính: "Không có thỏa thuận nào với Phan Lê Việt Anh và việc sửa bài thi" và sau đó yêu cầu HungNL đã ký vào tờ giấy này.

Download bản tường trình của HungNL
```
http://ubuntuone.com/7QAl7JOW0C7m6YV0ArwAM4
or http://www.mediafire.com/view/?zd6akbya0kwnxdb
```            

Tôi nhận thấy việc ép tôi vào tội sửa bài thi của HungNL mà không có sự đồng ý của HungNL là muốn qui chụp cho tôi tội trạng ngang với nhóm "HieuDM và đồng bọn", sự việc hoàn toàn khác bởi vì tôi đã nhiều lần liên lạc với FU thông qua DungHA. Ngoài ra còn có việc gặp trực tiếp 2 hiệu phó để nói về việc này và đưa video. Nên không thể xử lý tôi về vấn đề này. Nếu PhongNX muốn xử lý việc tôi hack vào server trường thì nên xử lý ngay khi tôi đưa video. Chứ đừng sử dụng chiêu bài "im lặng là vàng" rồi sau đó khi sự việc trở nên ầm ĩ lại muốn qui chụp tội tôi ngang HieuDM nhằm đuổi học tôi hoặc có thể nhờ chi tiết này để cứu vớt để tránh cho "HieuDM cùng đồng bọn" không bị đuổi học.
```
PhongNX: Em lấy được email khi nào?  
Tôi: khoảng 1 tuần sau khi bị hành hung.  
PhongNX: Thế làm thế nào em lấy được.  
Tôi: Em có nhờ 1 người lấy hộ em email từ phần mềm của HieuDM và sau đó người này có dạy em cách lấy email ra từ phần mềm của HieuDM.  
PhongNX: Em có thể gọi người này đến cho tôi gặp được không?  
Tôi: Gặp để làm gì ạ? Thầy thích thì em có thể lấy email của HieuDM trước mặt thầy luôn. Nên không cần phải gặp người dạy em làm việc này (Deobfuscator)  
PhongNX: Nhưng thầy muốn gặp người này?  
Tôi: (Nghĩ bụng: gặp để làm gì? 1 việc chả liên quan gì đến việc giải quyết vấn đề trong khi người đó có thể là bất cứ ai có khả năng Deobfucastor hoặc là 1 bài viết nào đó trên internet.) Không gặp được
```            

Việc PhongNX đòi gặp người này tôi không thấy có liên quan đến công việc điều tra, nếu muốn gặp người dạy tôi Deobfuscator, thì PhongNX nên yêu cầu gặp giảng viên dạy tôi Computer Network (dạy tôi cách dùng wireshark) và giảng viên dạy tôi dotnet (để tôi đọc và hiểu được code C#). Tình tiết này dễ gây cho những người bên ngoài xem xét là PhongNX đang định tìm sinh viên đứng đằng sau giúp đỡ tôi để tiện giả vờ hòi vài câu rồi để tiến hành "trù dập".  

Cuộc "hỏi cung" của PhongNX với tôi một vài người nếu nhìn vào thì thấy có vẻ "nói chuyện như chuyên gia" Nhưng tôi không thấy PhongNX không có thiện chí muốn xử lý việc HieuDM cùng đồng bọn sửa bài thi của tôi (quá chú ý và tập chung vặn HungNL không thỏa thuận cho tôi sửa bài thi, gặp riêng HungNL để yêu cầu viết tay thêm 1 đoạn và ký tên), PhongNX không có logic khi đã đòi yêu cầu gặp người dạy tôi Deobfuscator, không liên quan đến công việc chính là điều tra việc tôi bị sửa bài. Người này hoàn toàn giống với việc các thầy giáo dạy tôi lập trình trên lớp, chả có gì để gặp và nói chuyện. Khi tôi hỏi 1 câu duy nhất (Nếu bạn ý không đồng ý tại sao bạn ý lại gửi Exam Code cho em?) thì lại không trả lời được. Ngoài ra trước khi gọi tôi vào (khoảng 13h35) thì trước đó vào 13h21, Khi đang họp trước cùng ĐTV và 1 vài nhân viên của trường khác, PhongNX vẫn tranh thủ lên facebook để đăng 1 status và có 1 vài sinh viên vào comment. Việc này có vài người phản ánh với tôi. Ở đoạn bài viết này tôi không đưa nhận xét của mình về hành vi này, các độc giả có thể tự đọc và bàn luận  
Download bản capture status tại facebook của PhongNX
```
http://ubuntuone.com/3z7uP7ekGtnh8Z1jhZlK95
or http://www.mediafire.com/i/?hphkyfyku5g3pdh
```            

"Phạm Đức Anh" (AnhPD01069): ĐTV có hỏi về ComputerName của AnhPD, AnhPD trả lời -> ComputerName: A

27 Feb 2012:  
Gặp mặt với ĐTV để bàn về việc thu thập chứng cớ và xử lý. ĐTV có thông báo: đã cho người bất ngờ lên tại phòng học thu giữ máy tính của HuyenBTT (việc thu giữ và lập biên bản diễn ra khi máy đang bật), đã niêm phong lại và đang cất tại bên tập đoàn FPT. Thu máy tính đang còn bật, thu tại phòng học, đã phản đối gay gắt việc thu máy. Tuy nhiên vẫn lập biên bản và thu máy.  

Ngoài ra ĐTV có hỏi lại tôi về Exam Code là như thế nào và thông báo thêm về việc dấu hiệu sửa bài của tôi ở server không rõ ràng, của XXX thì rõ ràng. Nếu điều tra và chứng minh được XXX bị sửa bài thì sẽ lập luận theo phương án: XXX bị sửa bài thì tôi cũng bị sửa bài để yêu cầu cho tôi thi lại. Tôi trả lời lại: "Cái file XML đấy thì thích ghi gì chả được hả anh?". ĐTV ngạc nhiên hỏi lại: "Tại sao chú lại biết file XML". TÔi: Em đọc code nên biết (Thật ra thì mới đây là do liếc qua code IT client nên tôi chú ý chi tiết này (file xml log lại các thông tin đã Register tại server: ComputerName + ExamCode + AccountLogin, còn vấn đề xml tôi đã biết được về nó trước đây hơn 2 năm rồi).

Tối 28 Feb 2012:  
ĐTV có thông báo là đã tiến hành "forensic" laptop của HuyenBTT và lấy được rất nhiều thông tin đáng giá (Tôi sẽ không nói chi tiết những thông tin và bằng chứng thu được tại đây. Ở các phần sau của bài viết có thể tôi sẽ hé lộ dần thông tin). Từ những thông tin này thì HieuDM đã không thể chối tội, vì ĐTV đã chứng minh được chắc chắn người viết phần mềm để sửa bài thi của tôi là HieuDM chứ không phải 1 ai khác.

Sáng 29 Feb 2012:  
ĐTV có thông báo với "2 người của bên FU" là sẽ tiến hành đưa toàn bộ thông tin điều tra được và bằng chứng sang cơ quan chức năng để có thể tiến hành xử lý vụ việc có thể là truy tố.

Tối 29 Feb 2012:  
LinhTTT có gọi điện cho ĐTV để "nói chuyện" và ĐTV có sắp sếp cho 1 vài người trong nhóm HieuDM gặp mặt để nói chuyện vào ngày hôm sau. Tất nhiên là ĐTV rất ngạc nhiên với việc LinhTTT gọi điện cho ĐTV vì chỉ có 2 người tại FU (trừ tôi) biết được thông tin này. Tôi không được biết 2 người nào được biết thông tin này nhưng tôi có 1 thắc mắc rất lớn ở trong đầu của mình là: Ai là người đã tiết lộ những thông tin này cho LinhTTT (HieuDM cùng đồng bọn), liệu còn tiết lộ các thông tin khác nữa không? Tại sao lại đưa thông tin của ĐTV cho LinhTTT liên lạc để "nói chuyện". Tôi nhận thấy đây là việc nghiêm trọng vì đã tiết lộ thông tin mật để điều tra với các bị cáo. Còn cuộc nói chuyện riêng giữa LinhTTT và ĐTV thì tôi không được biết chi tiết vì ĐTV là người có chữ tín và danh dự nên sẽ không tiết lộ chi tiết các cuộc nói chuyện riêng. Và tất nhiên 2 "sếp" tại FU cũng sẽ không biết được chi tiết những bằng chứng của việc điều tra giữa tôi và ĐTV sau khi tiến hành forensic máy của HuyenBTT.

15 Mar 2012:  
ĐTV có gặp mặt tôi để thông báo về tình hình:

*   Đuổi học HuyenBTT (Với những bằng chứng thu nhận được tại máy tính của HuyenBTT: máy chứa phần mềm có khả năng sửa bài thi của tôi, ngoài ra khi "forensic" máy tính của HuyenBTT thì ĐTV có lấy thêm được 1 email khác và rất nhiều bằng chứng để có thể buộc tội là chỉ có HieuDM là người viết phần mềm sửa bài thi của tôi và cho các sinh viên khác gian lận, HuyenBTT đã gian dối, khai báo không thành khẩn nên bị đuổi học) và HieuDM (Viết phần mềm cho nhóm các sinh viên khác gian lận và sửa bài thi của tôi). Trường hợp HuyenBTT và HieuDM bị đuổi học là do không khai báo thành khẩn và nhận tội trước khi ĐTV đưa ra bằng chứng chi tiết.
*   Các bạn có thể thấy LinhTTT còn có thể có được thông tin mà chỉ có 2 "sếp" tại FU có và còn được cung cấp cả thông tin của ĐTV (số điện thoại) để "nói chuyện". Thì có thể nhóm HieuDM cùng đồng bọn có thể có được nhiều thông tin khác (Khi đọc log FU's Exam Server không thấy có dấu hiệu tôi đã bị sửa bài, mà sau này tôi đã điều tra về việc "Liệu có 'kẻ nào đó' cover track tại server này") Thế nên chắc chắn HieuDM sẽ không nhận tội, và nhờ chi tiết này ĐTV đánh giá HieuDM là người không biết hối cải và nhận lỗi nên đã quyết định đuổi học HieuDM (Tất nhiên là đã đưa ra bằng chứng trước PhongNX và HieuDM. Lúc này HieuDM đã không thể chối tội được)
*   Đình chỉ học 1 năm: LinhTTT, HaiPM. Sau này tôi biết thêm được người sửa bài môn SR lần 1 của tôi là LinhTTT. Nhưng LinhTTT đã viết bản tường trình để nhận tội nên tôi hoàn toàn đồng ý với việc đình chỉ học 1 năm LinhTTT chứ không đuổi học LinhTTT.
*   AnhPLV - Tôi: bị cảnh cáo cấp cơ sở FU Hà Nội. Tôi hoàn toàn đồng ý với việc này
*   HungNL sẽ bị học lại môn SQAT vì đã gửi Exam Code cho tôi. Tôi đã thảo luận với ĐTV về vấn đề này, ở đây PhongNX đưa bằng chứng là bản tường trình mà HungNL gửi PhongNX có đoạn được PhongNX yêu cầu HungNL ghi tay thêm vào. ĐTV có đề cập là HungNL gửi exam code cho tôi để chứng minh việc server trường có lỗ hổng và để làm sáng tỏ vụ việc HieuDM nên không kỷ luật HungNL. Tuy nhiên PhongNX có nói là HungNL không đồng ý cho tôi sửa bài thi mà còn gửi exam code cho tôi nên vi phạm qui chế thi nên sẽ bắt sinh viên HungNL học lại SQAT và đóng 100% học phí. Tôi đồng ý với việc xử lý này và đã quyết định sẽ đóng học phí học lại cho HungNL
*   Xử lý thêm 1 vài sinh viên khác.  
    Sau đó tôi chào tạm biệt ĐTV, ĐTV bận vào Sài Gòn ăn cưới "em gái" ;-). Tôi về nhà liếc trên facebook thì lấy có vài Moderator HVA rủ nhau đi ăn cưới `:<Sticker>one_punch:`

20 Mar 2012:  
FU có tổ chức 1 cuộc họp, ghi biên bản lại, gọi từng sinh viên vào nói chuyện với FU và Đại diện tập đoàn FPT. Phía FU bao gồm: Hiệu Phó PhongNX, Trưởng phòng Quản Lý và Đào Tạo, Đại diện bên đoàn trường QuangTV, Đại diện bên phòng sinh viên trường và đại diện tập đoàn FPT (ĐTV)  
Gọi tôi vào:
```
PhongNX: Ở đây có thầy là Nguyễn Xuân Phong là hiệu phó, Đây là anh *** là chuyên gia về lĩnh vực CNTT của tập đoàn, đây là XXX XXX Long Trưởng phòng Quản Lý và Đào Tạo, đây là thầy Trần Vũ Quang Đại diện bên đoàn trường, Kia là XXX XXX Dương, Đại diện bên cộng tác sinh viên.  
PhongNX: Sau lần gặp em hôm trước tết, thầy đã thông báo lại việc này với hội đồng nhà trường. Thầy DungHA không phải là người đại diện của nhà trường để đưa tin nên việc DungHA có nói em sẽ thi lại bằng giấy là không chính xác.  
Tôi nghĩ bụng: Sau lần gặp PhongNX có nói sẽ chuyển việc này tới hội đồng của trường và trường sẽ thông báo lại với tôi sau. Sau hơn 2 tuần liền không có ai liên lạc hay xử lý mà chỉ có 1 mình DungHA, vậy thì DungHA là người đã thông báo đưa ra quyết định của trường. Việc thi lại bằng giấy của DungHA nói hoàn toàn trùng khớp với ý kiến trước đó của AnhNK, vì thế nên đây hoàn toàn có thể là hội đồng trường đã họp và đưa quyết định như vậy.  
PhongNX: gặp sự việc như này em cần viết đơn gửi tới phòng đào tạo, nhà trường để xem xét và xử lý.  
Tôi nghĩ bụng: Thế sao sau lần gặp tôi PhongNX không bảo tôi viết đơn gửi đến phòng đào tạo để nhà trường xử lý, mà PhongNX lại nói là PhongNX sẽ chuyển tới hội đồng trường và nhà trường sẽ liên lạc lại sau? Thế có phải là PhongNX làm ăn tắc trách không khi PhongNX là 1 hiệu phó chuyên về mặt khen thưởng và kỷ luật?  
PhongNX: Việc của em đã được điều tra, việc này đã tốn rất nhiều thời gian và nhân lực của tập đoàn.  
Tôi nghĩ bụng: Tôi có phải BinhTG để phát lương cho nhân viên đâu mà lại nói về vấn đề thời gian và nhân lực với 1 sinh viên làm gì.  
PhongNX: Nhà trường sẽ tiến hành thông báo kết quả của việc này lên CMS (cms.fpt.edu.vn).Tuy nhiên các bạn sinh viên khác còn trẻ và chúng ta nên cho các bạn 1 cơ hội để làm lại cuộc đời. Để tạo cơ hội cho những sinh viên bị đuổi học sau này các bạn sẽ theo học tại nơi khác hoặc làm việc ở nơi khác thì trường sẽ chỉ đăng số lượng các sinh viên kỷ luật chứ không đăng chi tiết. Việc này chỉ những người trong cuộc biết với nhau.  
Tôi: Vâng ạ.  
PhongNX: 2 sinh viên bị đuổi học, 4 sinh viên bị đình chỉ học có thời hạn, 15 sinh viên bị bắt buộc học lại và đóng học phí 100% với các môn phải học lại, trong đó có 11 sinh viên bị kỷ luật ở mức cảnh cáo trước toàn trường (sẽ bị hạ 1 bậc bằng tốt nghiệp).  
Tôi nghĩ bụng: Có vấn đề rồi, tôi là người trong cuộc tại sao lại không đọc rõ tên tuổi từng sinh viên ra, nói là những người trong cuộc biết với nhau cơ mà.  
PhongNX: Trong trường hợp của em thì bài thi của em đã bị chỉnh sửa, mà theo qui định của trường về việc đảm bảo chất lượng thi cử thì những bài thi đã bị chỉnh sửa như em sẽ thi lại. Vì vậy em sẽ được nhà trường xếp lịch cho thi lại. Và việc em sử dụng phần mềm để can thiệp trái phép vào server trường, nhà trường đã xem xét và quyết định kỷ luật em ở mức cảnh cáo ở cấp cơ sở FUHN, Đây là 1 hình thức kỷ luật nhẹ, không ảnh hưởng đến việc tốt nghiệp của em. Lần sau em sẽ không được truy cập trái phép vào server trường nếu vi phạm sẽ bị xử phạt ở mức nặng.  
Tôi: *Liếc nhẹ mắt sang phía ĐTV với ý dò hỏi về việc PhongNX vừa nêu ra liệu có đúng như danh sách trước đó ĐTV đã cung cấp cho tôi hay không*  
ĐTV: *khẽ gật đầu 1 cái rất nhẹ* nói nhẹ thêm vào: Đi qua nhà người ta không khóa mà thấy không có ai ở nhà, vào kê lại bộ bàn ghế cũng là phạm tội. Kỷ luật ở mức đấy là hợp lý rồi.  
Tôi: *cười nhẹ 1 cái* Vâng ạ.  
PhongNX: Sau này mà có ai hỏi về xử lý vụ này thì em hãy trả lời là: "Xử lý thế là thoả đáng rồi"  
Tôi nghĩ bụng: Lại định dậy mình phải nói cái gì dạy à, cần gì phải dạy thế.  
ĐTV: Không, không nói gì trên các diễn đàn và cả facebook. Ai hỏi thì cứ bảo là sang hỏi ban truyền thông của trường và tập đoàn. Không người ta lại lợi dụng lời nói của em để nói xấu tập đoàn.  
Tôi nghĩ bụng: Quái, sao hôm đầu gặp mặt thì bảo là tạm close tại hva lại đợi điều tra xong thì thảo luận thoải mái, bây giờ lại bảo thế này. Nhưng mà tôi, ĐTV nói thì nghe vậy  
PhongNX: Em cứ bảo là sang gặp ban truyền thông của trường và tập đoàn. Có thể họ hỏi em rồi em trả lời trong 1 hoàn cảnh nào đấy. Khi dẫn chứng họ sẽ cắt bỏ hoàn cảnh đi để lợi dụng câu nói của em.  
Tôi: Vâng ạ.  
```            

Trường đưa cho 2 tờ giấy để ký, 1 tờ thì biên nhận lại việc tôi có mặt ở đây ngày hôm nay, 1 tờ cho nhiều sinh viên cùng ký, nhưng không ghi rõ ràng danh sách từng sinh viên bị kỷ luật thế nào (tất cả các sinh viên đều là "người trong cuộc"). Nhận thấy dấu hiệu có hành vi "phạm tội" của PhongNX tôi vẫn im lặng và note vấn đề này lại để giám sát về sau (Giống như việc làm của các trinh sát khi thấy kẻ có dấu hiệu phạm tôi sẽ âm thầm điều tra theo và bắt quả tang chứ không chạy ra bảo: "ê thằng kia, tao biết mày sắp phạm tội rồi đấy"). Quả này có vẻ có mưu mô gì rồi đây, mấy hôm nữa biết đâu mấy đứa đuổi học lại lên Hoà Lạc học, rồi quyết định thì ghi tên mấy đứa đã bỏ học vào thì sao. Được rồi "binh pháp yếm trá" thì "hạ hồi sẽ rõ".

Gọi AnhPD vào (Tôi được nghe kể lại tình hình, vì chỉ gọi từng sinh viên vào, trong phòng kín từ ngoài không quay chụp được và cách âm):
```
PhongNX: Em sẽ được nhà trường xếp lịch cho thi lại.  
AnhPD: Em được thi lại mấy lần ạ.  
ĐTV: *giật mình* bằng chứng tại server trường chỉ cho thấy em đã bị sửa bài 1 lần. Nên em chỉ được thi lại 1 lần.  
PhongNX: Em sẽ được thi lại 1 lần.  
ĐTV: Thế nào? Tâm phục khẩu phục chưa?  
AnhPD nghĩ bụng: Mình có phạm tội gì đâu mà tâm phục khẩu phục, mình chỉ là người bị sửa bài. Nhà trường điều tra ra thì cho thi lại, có gì mà "tâm phục khẩu phục"?  
AnhPD: Không nói gì. *quay sang hỏi PhongNX* Xong chưa ạ.  
PhongNX: Xong rồi.  
AnhPD: Em chào thầy em về.
```            

Gọi HungNL vào:
```
hongNX thông báo: Học lại đóng 100% học phí với môn SQAT do gian lận trong thi cử do gửi ExamCode cho bạn Việt Anh trong giờ thi.  
HungNL: Em không gian lận trong thi cử, em gửi ExamCode cho bạn Việt Anh khi em đã làm xong bài thi của mình.  

* Trong biên bản ký nhận HUngNL có ghi thêm: "Yêu câu nhà trường kiểm tra lại thời gian nộp bài và thời gian gửi sms ra ngoài."
```           

Quan sát thấy cuộc họp đã xong (ĐTV đi về).
```
Tôi (gửi SMS ĐTV): Em hi vọng là anh với FU không chơi trò Linh Miêu tráo chúa với em.  
ĐTV: Chú ăn nói với anh cần cẩn thận. Nó không phải là uy tín của riêng anh mà còn là của cả tập đoàn.  
Tôi: Đấy là chỗ anh em mình, em nói trước thế cho dễ sống với nhau.
```            

*ĐTV is calling.*
```
ĐTV: Chú ăn nói hơi bị linh tinh đấy, anh đã làm việc này là dùng uy tín của anh và danh dự của cả tập đoàn, làm sao có chuyện như thế được. Bên tập đoàn không bao giờ làm như thế, làm gì có chuyện Linh Miêu tráo chúa, nếu chú thấy đứa nào bị đuổi học mà nó đi học lại chú có quyền được kiện. Ăn nói với anh cần cẩn thận vì nó không phải là danh dự của anh mà là danh dự của cả tập đoàn  
Tôi: vâng ạ
```            

---

21 Mar 2012: ĐTV gọi điện nói chuyện về vấn đề xử lý ở trường.
```
ĐTV: Lúc thằng AnhPD có hỏi bị sửa bài mấy lần anh giật mình, anh trả lời nó là bằng chứng tại server chỉ cho thấy nó bị sửa bài 1 lần. Thế chú với nó bị sửa bài mấy lần.  
Tôi: Em bị sửa bài 3 lần, nó bị sửa bài 2 lần. Nhưng trong email chỉ ghi lại em bị sửa bài 2 lần, AnhPD bị sửa 1 lần. Đây là những lần do các sinh viên khác sửa, còn lần 3 của em và lần 2 của AnhPD bị HieuDM sửa, vì khi thi xong em thấy nó ngồi ngoài sảnh tầng 2 và em gửi file dat cho DungHA đưa cho khảo thí chấm lại thì cả 2 đều thừa điểm qua.  
ĐTV: Thế à, chú đưa email cho anh để anh vào kiểm tra lại.  
Tôi: Vâng ạ (Lần đầu gặp tôi cũng đề nghị đưa email cho ĐTV nhưng ĐTV nói để tôi cầm cho khách quan).  
ĐTV: LinhTTT có viết bản tường trình nhận là nó login vào sửa bài của chú với AnhPD, có thằng DucNT ngồi cạnh, nó bảo thằng DucNT trông cho nó sửa bài của chú với AnhPD.  
Tôi nghĩ bụng: Bên FU để lộ thông tin là thằng DucNT nó khai ra đứa nào sửa bài mình hay sao mà LinhTTT lại viết bản tường trình theo kiểu "tự sát" rồi kéo theo DucNT.  
Tôi: Vâng, em sẽ kiểm tra lại vấn đề này.  
ĐTV: Ừ
```            

Trước tiên `*101#` -> TK còn 12k. Nếu mà gọi cho DucNT mà nói chuyện đến khi hết tiền thì sẽ không gọi cho ĐTV được. Lúc sau chả lẽ lại nháy máy cho ĐTV rồi để ĐTV gọi lại, làm việc với ĐTV không thể chơi trò nháy máy. Mà nhắn tin cho DucNT để điện thoại 1 chỗ rồi đi đâu thì ngồi đợi cả ngày à? Làm sao báo cáo với ĐTV. Thôi thì nháy máy DucNT 1 cái rồi bảo nó gọi lại
```
Tôi: Alo, anh Đức đấy à? Gọi lại ngay cho em có việc gấp.  
DucNT: Ừ.
```            

*DucNT is calling* (Trong cuộc nc hơi tục, nhưng tôi xin phép để nguyên văn):
```
DucNT: Alo, có việc gì thế em?  
Tôi: Có việc anh ngồi trông cho LinhTTT sửa bài thi SR(lần 1) của em không? LinhTTT viết tường trình như thế.  
DucNT: Ái chà, bọn này định chơi mình à.  
Tôi: ĐM anh chứ, em hỏi thì trả lời là có hay không, đ*o vòng vo.  
DucNT: Ừ đúng, có chuyện này, Nhưng mà ...  
Tôi: Ừ, trả lời có hay không như thế cho nó đơn giản. Nhưng mà cái gì?  
DucNT: Lúc đấy anh ngồi ở đấy, lại dùng phần mềm của chúng nó để gian lận, con LinhTTT nó bảo thế nên anh bảo ừ, chả lẽ lại bảo không. Chứ anh cũng ngồi im không làm gì cả.  
Tôi: Được rồi, em hiểu, nếu em là anh thì em cũng sẽ bắt buộc phải làm như thế. Kể cả ngồi cùng sửa bài thi của em thì em cũng không trách anh cả. Thế sao ĐTV hỏi anh có quen LinhTTT không anh lại bảo không quen?  
DucNT: Làm gì có. Anh với nó cùng khoá 3, trước học cùng lớp nó thì làm sao mà khai là không quen được?  
Tôi: Thế sao hôm trước anh chỉ khai 3 đứa kia sửa bài môn SQAT của em, mà không khai LinhTTT sửa bài SR của em?  
DucNT: Tại con LinhTTT là bạn của anh nên anh không muốn khai nó ra, tha cho nó. Ai dè nó lại viết tường trình khai ra anh.  
Tôi: ĐM anh chứ, ng* v*. Nếu đã khai thì khai hết luôn, còn để sót làm gì. Được rồi, để em báo cáo lại với ĐTV.
```            

Tự tin gọi lại cho ĐTV vì TK còn khoảng 12k, có thể quản lý thời gian để chỉ nói chuyện với ĐTV dưới 6 phút.
```
Tôi: Anh *** à.  
ĐTV: Ừ, thế nào rồi?  
Tôi: Dạ, em vừa hỏi lại thằng DucNT rồi ạ. Nó khai nhận là có sự việc như thế anh ạ.  
ĐTV: Thế sao trước đây nó lại khai là không có việc đó?  
Tôi: Nó bảo với em là LinhTTT là bạn nó nên nó chỉ khai ra 3 đứa kia mà không khai LinhTTT.  
ĐTV: Anh sợ chúng nó lưu manh nghĩ ra trò đấy nên hỏi lại chú cho chắc (Đại để câu nói có nội dung thế này)  
Tôi: Vâng ạ, sự việc này hoàn toàn có thật.  
ĐTV: Ừ được rồi, vấn đề từ đầu đã thống nhất là "trọng chứng" hơn "trọng cung" nên anh sẽ vẫn đuổi học HuyenBTT và đình chỉ 1 năm với LinhTTT. Chú đưa email lại cho anh để anh kiểm tra lại bằng chứng ở email rồi xem xét kỹ lại vấn đề chú và XXX bị sửa bài mấy lần.  
Tôi: Vâng ạ.
```            

Sáng sớm 22 Mar 2012:  
Đưa mật khẩu email cho ĐTV. NGoài ra tôi đã tắt xác minh 2 bước đi, nhưng ĐTV gọi điện yêu cầu tôi bật xác minh 2 bước để an toàn cho email. Tôi liền bật xác minh 2 bước và Add số điện thoại của ĐTV vào email .

Tối 22 Mar 2012:  
ĐTV thông báo là đã cho người sang phía FU để kiểm tra lại log server bên phía FU để xem xét cho AnhPD và tôi được thi lại 2 lần SR (nếu thi lần 1 bị trượt)  

Ở lần sửa bài thứ 3 của tôi (SR lần 2) và thứ 2 của AnhPD (SR lần 2) thì đều bị delay 1 phút (time bắt đầu làm bài + thời gian làm bài + 1 phút -> thời gian nộp bài). Ở đây phía FU bảo là không có dấu hiệu bị sửa bài, việc này là do khi đang nộp bài thì bị lỗi mạng, nên phải nộp nhiều lần, sau 1 phút mới nộp được nên xảy ra hiện tượng này. Tuy nhiên trong lần thi này cả tôi và AnhPD đều nộp bài 1 lần được luôn, ngoài ra khi tôi gửi file dat cho DungHA mang qua phòng khảo thí chấm lại thì cả tôi và AnhPD đều thừa điểm để qua. Nhưng thấy phía FU server bằng chứng sửa bài của tôi không có dấu hiệu bị sửa bài, ngoài ra với môn SR tôi chỉ cần thi 1 lần là thừa điểm qua (và sau này đã thi qua), việc chứng minh tôi bị sửa bài lần 2 SR không kỷ luật được thêm 1 sinh viên nào, việc này cũng tốn rất nhiều thời gian và nhân lực nên tôi đồng ý với ĐTV và không thắc mắc gì nữa.

27 Mar 2012:  
nhận được thông tin qua yahoo khi có 1 người cung cấp thông tin.
```
http://ubuntuone.com/69zkOUVHmSK3E8Qj7KQuIZ
or http://www.mediafire.com/view/?90hbif8fgrb5y2d
```            

Giải thích qua 1 phần đoạn log chat đã được tôi nặc danh thông tin của người cung cấp.

*ABC: Đây chính là 1 trong 5 sinh viên hành hung tôi, ngoài ra còn nằm trong list sinh viên gian lận trong email. Phía FU đã đăng thông báo là đã kỷ luật nhóm 5 sinh viên này ở mức cảnh cáo trước toàn trường.*
```
http://ubuntuone.com/1bQutkRVHJxbbtjPrLD4aB
or http://www.mediafire.com/i/?y7flzsx0dwl6jlb
```            

Từ giờ tôi sẽ viết ông hiệu phó trong đoạn log chat này ở dạng "ông hiệu phó". Độc giả chý ý chi tiết này để đọc tiếp bài viết của tôi.  
Theo tôi được biết thì khi sinh viên bị kỷ luật ở mức cảnh cáo trước toàn trường, trong vòng 6 tháng nếu "phạm tội" sẽ bị đình chỉ 1 năm(tôi sẽ kể về vấn đề này ở cuối bài). Nên tôi bắt đầu suy nghĩ và nghi ngờ có trò gì ở trong vụ này rồi. (1)  
Sau những suy nghĩ trên thì tôi có 1 cuộc nói chuyện với ĐTV về việc tôi nhận được thông tin như vậy.
```
ĐTV: Không bao giờ có chuyện 1 hiệu phó làm những việc như thế. Anh đã dùng uy tín của mình ra để xử lý việc này thì làm sao có thể có chuyện dìm được. Càng ngày anh càng thất vọng về chú, chú không có lòng vị tha, đã bảo cho mấy đứa sinh viên bị đuổi học cho nó học nốt học kỳ này để biết đâu các nơi khác công nhận các tín chỉ đã học cho chúng nó.  
Tôi: Không phải vậy, việc cho các sinh viên này học hết kỳ em cũng đồng ý. Tại những việc như này em không thích công khai lên internet để thảo luận nên anh em mình nghiên cứu và điều tra với nhau.  
ĐTV: Chú doạ anh đấy à, chú thích thì cứ cho lên mạng thoải mái. Không được ăn nói kiểu đấy với anh.  
Tôi: Hay anh thử điều tra hiệu phó nào hay làm việc với anh xem có vấn đề hay không?  
ĐTV: Anh TungLT là ... (tôi không nhớ rõ, hình như là phó chủ tịch Hội Tin học Việt Nam) nên không bao giờ làm thế. Còn Anh ThanhNK là triệu phú đô la, tiền anh ấy làm gì thiếu mà làm như thế?  
Tôi: Từ hồi làm việc với anh đến giờ có bao giờ em nhắc đến TungLT hay ThanhNK đâu, Anh thử điều tra PhongNX xem?  
ĐTV: Anh đã xử lý việc này thì không có chuyện dìm, sao người ta nói 8 triệu chú lại tin thế? Chú biết lương 1 hiệu phó là bao nhiêu không?  
Tôi: Em nghe sinh viên nó đồn là 40 triệu.  
ĐTV: Đấy, thế thì sao lại đi nhận 8 triệu, có 80 triệu cũng không mua chuộc được anh. Chú toàn đi nghe tin đồn ở đâu đấy rồi ăn nói vô tổ chức vô chính phủ với anh.  
Tôi: Vâng, tại vì em thấy có (1) nên em mới thắc mắc thôi ạ.  
ĐTV: Ơ, anh tưởng việc sinh viên hành hung chú đã xử lý bên công an rồi mà?  
Tôi: Đầu tiên em viết đơn cho trường, chính nhân viên trường đi ra lấy xe máy về cho em. Bà bán nước gần đấy có nói rõ những sinh viên hành hung em là sinh viên của Đại học FPT. Nhưng hôm sau, PhongNX nói với mẹ em là không phải sinh viên trường mà là người ngoài trường. Nên em mới không đồng ý và báo sang bên công an. Sau đó hoà giải bên công an.  
ĐTV: Thế bên công an đã xử lý rồi thì bên trường không xử lý nữa chứ.  
Tôi: Việc bên công an xử lý là bên công an, còn bên trường xử lý là bên trường. Bên trường có nói là đã kỷ luật ở mức cảnh cáo trước toàn trường.  
ĐTV: Sao chú biết?  
Tôi: Có thông báo ở CMS ngay sau hôm em đăng bài lên HVA mà anh.  
ĐTV: Thế bây giờ chú kiểm tra lại qui định của trường, rồi viết email hỏi PhongNX về vấn đề các sinh viên đấy. Nếu sự việc là thật thì PhongNX sẽ chuyển danh sách qua để anh xử lý. Vì PhongNX không chuyển danh sách và nói về qui định này nên anh không biết.  
Tôi: Vâng ạ, để em kiểm tra lại. (Nhưng tôi không làm vì rất mất thời gian và công sức nếu có thành công thì cũng chỉ bắt được vài sinh viên bị đình chỉ 1 năm không thể bắt được "con cá lớn").
```            

Nhưng sau cuộc nói chuyện trên thì ĐTV có nói đến "thích thì chú cứ cho lên mạng thoải mái". Vì thế nên từ đây tôi có thể đưa toàn bộ thông tin và những cuộc nói chuyện riêng với ĐTV lên mạng. Vì ĐTV làm ăn hoàn toàn minh bạch, cung cấp và cập nhật thông tin cho tôi từng ngày để cùng nghiên cứu điều tra.  

Đến bây giờ khi viết lại những thông tin này tôi thấy mình bị ĐTV coi là ăn nói láo toét, vô kỷ luật, vô chính phủ cũng đúng. Vì xét nếu thông tin mà XYZ cung cấp là lời nói của "ông hiệu phó" sau khi ĐTV đã chính thức điều tra và xử lý bên FU thì sẽ bị coi như tôi nói ĐTV nhận "hối lộ". Nhưng nếu "ông hiệu phó" nói sau khi tôi vừa báo cáo việc này lên trường (trong cuộc gặp mặt 4 người: Tôi, DungHA, PhongNX, AnhNK) và trước khi ĐTV chính thức điều tra và xử lý thì liệu có chuyện 'dìm' hay không? Và sau đó đã như thế nào? Để biết được những chuyện này thì "hạ hồi sẽ rõ", về cuối truyện các bạn sẽ lần lượt thấy từng "nước cờ cao tay" được hé lộ ra.

5 Apr 2012:  
Được 1 nguồn tin có độ chính xác 99% thông báo rằng sắp tới trường sẽ đuổi học LinhTTT chứ không phải là HuyenBTT, vì LinhTTT đã viết tường trình nhận hết tội (vấn đề này khớp với thông tin nói chuyện ngày 21 Mar 2012 với ĐTV. Tuy nhiên ĐTV vẫn đuổi học HuyenBTT và chỉ đình chỉ 1 năm LinhTTT, nói là nhận hết tội thì không hẳn, vì chỉ là nhận tội lần LinhTTT sửa bài thi môn SR (lần 1) của tôi. Còn DucNT có nói là HuyenBTT, HaiPM và TienND sửa bài thi môn SQAT của tôi, nên LinhTTT không thể nhận tội thay cho 3 sinh viên kia mà chỉ là viết tường trình nhận tội để hưởng "khoan hồng"). Theo nguồn tin này thì HuyenBTT kỳ sau sẽ vẫn đi học bình thường tại FU.  

Tôi nghĩ bụng: Quái. Thế này thì đúng là PhongNX lợi dụng kẽ hở của lần gọi từng sinh viên vào để đọc quyết định, do chỉ đưa ra số lượng nên sẽ dễ "lừa dưới", còn sau sự kiện này thì ĐTV sẽ về và làm công việc của mình bên tập đoàn FPT nên sẽ dễ "dối trên".  

Suy nghĩ 1 ngày liền, vào tối 6 Apr 2012 tôi có gởi 1 message cho ĐTV hỏi kỹ lại về vấn đề có đúng là sẽ đuổi học HieuDM và HuyenBTT hay không? Thì ĐTV gọi điện lại hẹn sáng 7 Apr 2012 gặp nói chuyện tại bên toà nhà FPT.

Sáng 7 Apr 2012:  
gặp ĐTV nói chuyện:
```
ĐTV: Anh không hiểu được chứ đang làm gì? Sự việc đã xử lý xong rồi thì hãy để nó xong. Càng ngày anh càng thất vọng vì chú, chú là 1 người không có lòng vị tha, ích kỷ.  
Tôi: Em hỏi lại anh việc đuổi học HieuDM và HuyenBTT vì Em có nguồn tin là FU sẽ đuổi học HieuDM và LinhTTT.  
ĐTV rít 1 hơi thuốc lá thật sâu, đầu tựa vào ghế, mắt nhắm lại lim dim như điếu thuốc vào buổi sáng gây cho ĐTV cảm giác lâng lâng. Sau đó ĐTV nhả khói thuốc ra qua 2 khe mũi và bắt đầu nói với tôi  
ĐTV: Anh không ngờ chú lại sống được đến ngày hôm nay, nghe người ta tung tin thế mà cũng tin luôn, làm gì có chuyện như thế. Thằng nào làm thế thằng đấy tan xác ngay. Chú nói thế này người ta đánh giá chú là thằng đang tung tin đồn với âm mưu để phá hoại FPT  
Tôi: Hôm trước họp từng người chỉ đưa số lượng ra, đăng lên cms.fpt.edu.vn cũng chỉ đưa số lượng. Thế thì việc hoán đổi vị trí LinhTTT và HuyenBTT là bình thường.  
ĐTV: Không bao giờ có chuyện đấy, anh còn cầm biên bản ở đây cơ mà.  
Tôi: Biết đâu cái biên bản anh cầm nó cũng ghi số lượng thì lúc đấy làm thế nào?  
ĐTV: Làm gì có chuyện đấy, trong biên bản phải ghi danh sách cụ thể. Hiệu trưởng Lê Trường Tùng(TungLT) không bao giờ làm thế. Thầy Nguyễn Khắc Thành(ThanhNK) cũng không bao giờ làm thế. Chú biết TungLT làm ... (Tôi không nhớ rõ, hình như ĐTV nói là Hội tin học thành phố Hồ Chí Minh) không? Còn ThanhNK thì là triệu phú đô la có 1 bài báo của FPT đã viết về ThanhNK rồi đấy, chú tìm đọc mà xem. 2 người này không bao giờ làm những việc như thế.  
Tôi: Từ lúc làm việc với anh đến bây giờ có bao giờ em nhắc đến TungLT hay ThanhNK làm bậy đâu? em sợ PhongNX lúc đấy in ra 1 loạt quyết định kỷ luật lừa TungLT ký thì sao, lúc đấy thì em sợ oan cho TungLT thôi. Vì em cũng hay ký bừa mà (Sau lần này tôi bắt đầu chú ý và chừa trò không đọc kỹ rồi thò tay vào ký luôn).  
ĐTV: làm sao có cái chuyện như thế được?  
Tôi: Thì có mỗi anh em mình có 1 cái "cert" như này để liên lạc, biết đâu PhongNX lợi dụng là "Man in The Middle" làm như thế thì sao? Lúc đấy thì oan cho TungLT, PhongNX sẽ qua loa hoặc không đưa biên bản cho TungLT đọc rồi sau đó đưa 1 loạt quyết định kỷ luật cho TungLT ký, TungLT lại không chú ý đến chi tiết từng sinh viên để so với biên bản. Lúc TungLT ký vào đống quyết định đấy thì sẽ xử lý kiểu gì đây? Mang tiếng TungLT ra.  
ĐTV: Tầm bậy. Không bao giờ có chuyện đấy, chú lần sau đừng có nghe các tin lung tung, người ta tung tin đồn kệ người ta, lần này anh bỏ qua, lần sau mà ăn nói thế này thì đừng nói chuyện với anh.  
Tôi: Vâng ạ.
```            

Vài ngày sau ...  
Phòng Quản Lý Đào Tạo FU (QLĐT) có xếp lịch cho tôi thi lại môn SR. Nhưng không sắp lịch cho tôi thi lại môn SQAT. Sau đó tôi đã email với PhongNX và Trưởng Phòng Đào Tạo để yêu cầu giải quyết việc này (ngoài ra còn nộp cả bản cứng tới QLĐT). Ban đầu thì do bằng chứng tại FU's exam server nên phía FU chỉ chấp nhận cho tôi thi lại SR, sau này ĐTV có viết email sang phía FU và tôi được thi lại xếp lớp thi lại SQAT.  
Email với PhongNX về việc yêu cầu xếp lịch thi lại SQAT:
```
http://ubuntuone.com/2yU1Gn8cTwSYERoIGiA40C
or http://www.mediafire.com/?ocn8h26v0wnglkt
```            

pass giải nén: `hvaonline.net`

10 Apr 2012: FU gọi từng sinh viên đến gặp để đưa quyết định kỷ luật cho từng sinh viên, Hiệu phó PhongNX ký quyết định kỷ luật. Cầm quyết định tôi mỉm cười 1 cái ;-)
```
http://ubuntuone.com/2YhucwgYLFG80AkX2AQo0Q 
or http://www.mediafire.com/i/?ha3kv7d2886w2bi
```          

\-> Nhắn tin báo cáo với ĐTV: Em đã nhận quyết định kỷ luật và PhongNX ký ! `:<Sticker>big_smile:`.

11 Apr 2012:  
Nhận được tin HuyenBTT không bị đuổi học, nói chuyện với ĐTV: "Em nói nó sẽ Linh miêu tráo chúa mà, bây giờ nó thế thật rồi".  
ĐTV: Chú hiểu sai vấn đề rồi. Sau đó tôi và ĐTV hẹn gặp để nói chuyện về vấn đề này.

---

Sau 2 ngày liên tục ĐTV bận họp, vào tối ngày 13 Apr 2012 ĐTV có sắp xếp 1 cuộc gặp mặt để nói chuyện với tôi, diễn ra trong 2h30' đồng hồ.  
Thật ra thì trước tiên cũng phải cần xác định mục đích của cuộc nói chuyện này:
```
ĐTV: Đã điều tra mọi việc hết sức, ngoài ra còn nhiều nguồn tác động như danh dự của cả tập đoàn và nhiều thứ khác (nhìn cái cách nguồn tin chỉ 1 sếp của FU biết mà LinhTTT còn được cung cấp số điện thoại của ĐTV là các bạn đã hiểu được 1 phần sự việc) + 1 server không lưu lại log về việc tôi đã bị sửa bài + việc ký quyết định này là khi bên FU xin "khất" đến cuối kỳ nên khi ĐTV về bên tập đoàn thì "gạo đã nấu thành cơm". Lúc này phía FU sẽ đưa ra lập luận là do LinhTTT đã viết tường trình nhận tội sửa bài môn SR của tôi và AnhPD nên FU đã đuổi học LinhTTT thay vì HuyenBTT. Từ những thứ trên tôi cũng thông cảm cho ĐTV. Nhưng trước đó tôi có thêm rất nhiều thông tin nên tôi sẽ đợi để "bắt con cá lớn".
Tôi: Em đã nói rồi mà, nó đã linh miêu tráo chúa?  
ĐTV: Chú chả hiểu "linh miêu tráo chúa" là gì, Ở đây HieuDM là thằng đầu án, nó đã bị đuổi học rồi, còn vấn đề đổi vị trí giữa LinhTTT và HuyenBTT thì do LinhTTT đã viết bản tường trình nhận nó sửa bài của chú với AnhPD nên FU có thể đuổi học nó.  
Tôi: Thế thằng DucNT nó khai ra 3 đứa kia sửa bài thi của em thì sao? Với em thế cũng là "linh miêu tráo chúa"  
ĐTV: Tại thằng DucNT nó không chịu khai ra LinhTTT từ đầu nên bên FU dựa vào vấn đề này để bảo LinhTTT đã nhận tội nên đuổi học LinhTTT chứ ko đuổi HuyenBTT? Chú bảo đây là "linh miêu tráo chúa" thế trong vụ án này đứa nào là 'chúa'?  
Tôi: Đứa nào cũng là 'chúa' hết, có thể có nhiều 'chúa' con.  
ĐTV: Chú chả hiểu vấn đề.  
Tôi: Anh ăn nói không nhất quán.  
ĐTV: Anh nói không nhất quán chỗ nào?  
Tôi: Sao hôm trước em gặp anh bên toà nhà FPT, em nói về chuyện LinhTTT với HuyenBTT rồi thì anh bảo không có chuyện đấy.  
ĐTV: Có thể lúc đấy anh nghe nhầm nên anh tưởng là chú bảo HieuDM anh mới bảo thế.  
Tôi: .......  
ĐTV: ......  
Tôi: ......  
ĐTV: Chú ăn nói với thái độ láo toét. Còn nói kiểu đấy anh không nói chuyện với chú nữa.  
Tôi: Thế thì thôi em không cần nói chuyện với anh nữa.
```            

Nghỉ giải lao 5 phút. Nhưng ĐTV là đàn anh, nên không chấp sự thiếu hiểu biết của tôi, nên đã chủ động nói chuyện và kể chi tiết lại quá trình điều tra và giải thích từng chi tiết với tôi, tôi có hỏi đáp và ĐTV có trả lời (xin tạm thời chưa công bố chi tiết cuộc nói chuyện này). Nhưng ĐTV đã ân cần, từ từ giải thích và nói chuyện chứ không có dùng gì mua chuộc tôi. Vì với các vấn đề "chạm nọc" như thế này thì có 800 triệu tôi cũng không nghe. Lúc này tôi đã đồng ý với việc giải quyết vấn đề như thế này. 

Nhưng tôi nghĩ bụng: Được rồi, mình hay bị mang tiếng là không có lòng vị tha nên vụ này tạm thời nếu giải quyết đúng nguyên như này thì mình sẽ đồng ý không truy cứu, các thông tin quá nhỏ không đáng để bỏ sức viết bài và tiết lộ mối quan hệ cũng như các cuộc nói chuyện riêng giữa tôi và ĐTV, việc tiết lộ các thông tin riêng này ảnh hướng đến chữ tín của tôi vì để lộ các cuộc nói chuyện riêng, nếu như sự việc thế này thì chưa đáng để tôi làm thế. "Con cá" còn quá bé (Trước đó tôi có nhận được thông tin HuyenBTT là sinh viên bị đình chỉ 1 năm sẽ đi học bình thường vào học kỳ sau thấy đây là việc "ai đó" đã âm mưu từ trước và lợi dụng trò chỉ đọc số lượng trong lần đọc quyết định kỷ luật và đăng số lượng tại CMS nên tôi sẽ đợi việc này để "bắt cá lớn").  
Tôi và ĐTV tạm biệt nhau đi về.

### **Vào học kỳ mới (Khương tử nha ngồi câu cá)**

Xử lý công việc của HungNL:  
Tôi không bỏ rơi những người làm việc cho tôi, cần phải có trách nhiệm với những người bị liên lụy. Khi có tin HungNL bị học lại và bắt buộc đóng học phí 100% môn SQAT (3-> 4 triệu vnđ). Nếu mà là đền bù đúng thì phải đền bù như sau: Tiền ăn ở trong thời gian học SQAT (2 tháng: 3tr\*2 = 6tr) + Tiền học phí 100% môn SQAT = khoảng 10tr vnđ. Nhưng do tôi là 1 sinh viên nghèo nên HungNL và tôi đã thống nhất là tôi chỉ cần đóng học phí 100% môn SQAT cho HungNL.  
Xét thấy việc kỷ luật LinhTTT và HuyenBTT khác với buổi đọc quyết định cho từng sinh viên, nên tôi và HungNL "kháng án" lại quyết định kỷ luật của HungNL vì trước đó trong cuộc họp gọi từng sinh viên vào để đọc quyết định HungNL đã không đồng ý với mức kỷ luật FU đưa ra và đã yêu cầu kiểm tra lại log server và thời gian gửi tin nhắn trước khi kết luận cậu ta vi phạm qui chế thi.  
Sau đây là thông tin cuộc nói chuyện giữa HungNL - PhongNX:
```
http://ubuntuone.com/3K4lBbIkIHW6JCGhQzExsr
or http://www.mediafire.com/?0cjc3l7dbace4gy
```            

pass giải nén: `hvaonline.net`

Dễ dàng nhận thấy sau email thứ 3 thì PhongNX bắt đầu sử dụng phương án không trả lời HungNL nữa. Đây là hành động dìm việc này xuống hay là do PhongNX không biết lập luận thế nào để buộc tội HungNL nên bắt đầu dùng quyền lực của mình: "Tao không trả lời mày tao chả sao cả, Mày cứ phải học lại không thì không được ra trường, con kiến mà kiện củ khoai nhé". PhongNX đang xử ép HungNL (nhìn thì có vẻ nghiêm đấy, không biết có nghiêm minh tất cả không thì "hồi sau sẽ rõ").  
Tôi nghĩ bụng: Được thôi, Hiệu phó PhongNX có quyền nên được làm thế mà. Mấy bữa nữa có khi PhongNX thích thì các sinh viên bị đình chỉ 1 năm vẫn đi học bình thường ấy chứ.

Sau 1 thời gian ngắn, ở trường có vài sinh viên hỏi tôi: "Ơ, tưởng anh bị đình chỉ học 1 năm rồi?" "Ơ, mày bị đình chỉ học 1 năm rồi mà, đến trường làm gì thế". Ngay tại Mộc Châu thì có tin đồn tôi bị đình chỉ học 1 năm, thậm chí đến cả tai họ hàng nhà tôi như: bà ngoại, dì, mợ, ... Tôi nhận định đây là những "kẻ gian" đang tung tin đồn thất thiệt, để nhằm làm loạn cho đám đông không biết được sinh viên nào bị đuổi học, sinh viên nào bị đình chỉ học có thời hạn. Kiểm tra thấy thi thoảng HaiPM và HuyenBTT đi qua trường nhưng không học môn nào cả.  
Lúc này tôi nghĩ: "Chắc là chúng nó chưa đăng ký kịp môn để theo học, hoặc là đang đợi sau khi tin đồn lan thật mạnh và thật xa thì sẽ bắt đầu đi học từ block sau (FU học theo tín chỉ, và 1 học kỳ chia làm 2 block lớn và 1 block nhỏ để các sinh viên đăng ký môn và hoàn thành trong 1 block). Vì FU rất giỏi vấn đề 'truyền thông' nên nếu chỉ cần 1 người có vị trí muốn đồn tin gì thì tin đó sẽ đi ra xa và nhanh."

Trong lúc này tôi bắt đầu nghiên cứu về vụ "8 triệu tiền dìm". Không thể nào lại đơn giản như vậy, chắc chắn là tôi và ĐTV đã bị qua mặt ở điểm nào đó. Tiến hành tổng hợp tại toàn bộ thông tin tôi có được. Tôi chợt giật mình vì phát hiện ra có người đã tính toán quá kỹ và chi tiết. Tuy nhiên, nếu biết tận dụng hết tất cả các thông tin ĐTV điều tra minh bạch và cung cấp cho tôi thì có thể phát hiện ra những hành động này : `:<Sticker>one_punch:`

Đọc từ đầu bài viết đến giờ? Các bạn có nhận ra tôi và ĐTV đã gặp khó khăn gì không? Nếu chú ý kỹ các bạn sẽ thấy được chi tiết: log tại FU's exam server không có "dấu hiệu" tôi bị sửa bài. Tôi bắt đầu điều tra từ đây để bóc tách ra được toàn bộ vấn đề, tôi tạm gọi đây là chuyên án XML.

* * *

### **Chuyên án XML.**

Tóm tắt thông tin có được để chuẩn bị cho chuyên án này:

*   Tôi bị sửa bài 3 lần: 1 lần SQAT, 2 lần SR.
*   XXX bị sửa bài 2 lần: 2 lần SR (do chỉ học mỗi môn SR thi trên máy, đã học qua SQAT từ trước rồi)  
    Trong email lưu lại log tôi bị sửa bài 1 lần môn SQAT, 1 lần môn SR (Lần 1). AnhPD 1 lần môn SR (Lần 1)  
    DucNT khai lần 1 môn SQAT của tôi bị 3 sinh viên sửa: TienND, HuyenBTT, HaiPM.  
    LinhTT nhận tội sửa bài 1 lần môn SR của tôi và AnhPD.  
    Ở lần 2 môn SR của tôi và AnhPD không có log tại email dohieu1991. Tuy nhiên khi thi xong tôi có thầy HieuDM và 1 nhóm lâu la ngồi ở sảnh tầng 2, Đây là lần trực tiếp Coder HieuDM ra tay sửa bài của tôi, nên có thể bản chạy tại máy HieuDM không cho function gửi email vào. Chi tiết chứng minh lần này tôi và AnhPD bị sửa là tôi đã gửi file \*.dat cho DungHA để mang sang phòng khảo thí chấm lại và được biết cả tôi và AnhPD đều thừa điểm qua. (Lần này tôi và AnhPD đều chắc chắn sẽ được ít nhất 5 điểm)  
    \-> Vậy tổng cộng chúng tôi bị sửa bài 5 lần.

Mỗi lần thi thì 1 sinh viên sẽ có 1 file `.xml` (log lại thông tin register cuối cùng: ExamCode + ComputerName + LoginID) và 1 file dat ( bài làm).  
Khi ĐTV tiếp cận FU's exam server thì thấy dấu hiệu sửa bài của tôi không rõ ràng (cụ thể là các file XML đều log lại thông tin regiser đều là của tôi), của AnhPD thì rõ ràng nhưng chỉ là 1 lần (Dựa vào lần đọc quyết định kỷ luật cho từng sinh viên, AnhPD đã thắc mắc được thi lại mấy lần, và ĐTV có thông báo là bên phía server chỉ ghi nhận AnhPD bị sửa bài 1 lần).  
Ít nhất là có LinhTTT đã nhận sửa bài của Tôi và AnhPD, Vậy tại sao trong 5 lần (3 của tôi, 2 của AnhPD) mà chỉ lưu lại AnhPD bị sửa bài 1 lần còn của tôi thì không bị sửa bài lần nào? Vậy thì có kẻ nào cover track tại server này không? Giả sử nếu không có ai cover track tại sao trong tổng cộng 5 lần bị sửa mà chỉ lưu lại log đúng 1 lần? Đây vẫn là 1 câu hỏi mà chắc là chỉ "người trong cuộc" mới có câu trả lời.  
Nhưng chắc chắn rằng kẻ cover track không phải là HieuDM. Bời vì lí do đơn giản nhất là mọi việc đều được tôi âm thầm điều tra và lấy được email sau đó gửi tới FU đều bí mật chỉ public ra khi đăng tại HVA, vậy nên HieuDM sẽ không biết để cover track. Sau này có thời gian tôi sẽ viết thêm 1 bài để chứng minh HieuDM không phải là 'kẻ' cover track.

Nghiên cứu lại log chat "8 triệu 1 người". Trước đây khi nhận được thông tin này tôi nói với ĐTV và bị ĐTV "dạy dỗ" cho 1 trận 44 phút liền. Do lúc này ĐTV nghĩ rằng việc "ông hiệu phó" nói khi ĐTV đã trực tiếp điều tra và xử lý nên mới phản ứng như vậy vì khi ĐTV đã làm việc thì không thể "dìm" được. Nhưng Nếu "ông hiệu phó" nói sau khi tôi báo sang bên FU và trước khi ĐTV tiếp nhận và xử lý vụ việc này thì chuyện gì đã xảy ra?  
Trước tiên nhắc lại việc PhongNX nói trong lần đọc quyết định cho từng sinh viên, PhongNX có nói: Sau lần gặp tôi trước tết thì PhongNX đã nói việc này tới hội đồng trường. Sau đó PhongNX nói những gì DungHA nói không phải là quyết định của trường, tôi cần phải viết đơn gửi để phòng đào tạo thì trường mới giải quyết. Tôi có 1 thắc mắc là: "Liệu PhongNX chuyển việc này tới hội đồng trường rồi, mà Hội đồng trường lại không xem xét, và nếu đã xem xét chả lẽ lại không đưa ra quyết định". PhongNX không biết được tôi đang nắm các thông tin sau:

01 Feb 2012:  
khoảng 13h, Khi tôi đang ngồi ngoài quán nét chơi DotA (đang godlike invoker) thì DungHA có gọi điện nhắc tôi đọc email, và DungHA có nói là chiều nay sẽ họp hội đồng trường để xử lý việc của tôi.  
Nội dung email như sau:
```
http://ubuntuone.com/0C5wnVfWdVwtVVBv5rAYHT
or http://www.mediafire.com/?b093xei0p51777v
```            

pass giải nén: `hvaonline.net`  
Theo tôi hiểu nội dung email này thì DungHA yêu cầu tôi gửi bản IT client do tôi code lại và dùng sửa bài của HungNL để vào buổi chiều họp hội đồng trường DungHA sẽ chuyển tới hội đồng trường. Và sau đó, sau khi tôi có gửi email và SMS cho DungHA thì DungHA có nói là đang nói chuyện với thầy Trưởng phòng Quản Lý và Đào Tạo để xem xét cho tôi và XXX thi lại.  
Việc trường đã thành lập hội đồng hoàn toàn trùng khớp với thông tin mà Hiệu phó AnhNK cung cấp cho tôi.
```
http://ubuntuone.com/0hvsDSCFAE425dPgz97nyU
or http://www.mediafire.com/?kvg5hhv2gzc0d6q
```            

pass giải nén: `hvaonline.net`

PhongNX có nói là phải viết đơn thì trường mới xử lý, tại sao AnhNK lại nói là: "Đang chờ kết quả từ ban đào tạo"?

Và cách xử lý thì sau đó các bạn đều đã biết được sau khi đọc xong phần 1.  
PhongNX có thể phủ nhận việc trường sẽ tiến hành cho tôi thi trên giấy và dựa vào các thông tin tôi đưa lên hva để "ngụy biện". Nhưng PhongNX không biết rằng tôi còn biết chính xác cả thời gian FU tiến hành họp và xử lý vấn đề. (Kinh nghiệm là không bao giờ đưa hết bằng chứng và lập luận ra vội, nhiều người sẽ căn cứ vào đó để trả lời và chối bỏ mọi thứ mà họ coi là sẽ chối bỏ được)

Các bạn có thấy cách xử lý này giống với việc PhongNX đã xử ép HungNL khi cậu ta viết email trả lời hay không? Vậy liệu có phải là trường đã "dìm" rồi hay không? Có thể dùng quyền lực để xử ép được tôi khi đó là FU đang chơi theo luật của FU, tôi sẽ thua. Nhưng cuộc sống không phải chỉ có 1 trò chơi. Khi chơi theo luật của tôi, tôi đã đăng lên hvaonline.net và các bạn đã thấy sự việc đã diễn biến như thế nào.  
Tiếp tục vấn đề khi bên tập đoàn cử người sang điều tra và xử lý vụ việc, ĐTV khi tiếp cận với FU's exam server đã không thấy tôi có dấu hiệu bị sửa bài nào hết trong tất cả 3 lần thi. Vậy thì theo bạn chuyện gì đã xảy ra với FU's exam server trước khi ĐTV tiếp cận vào `:<Sticker>one_punch:`.

Sau lần gặp đầu tiên 2 hôm (vào thứ 4, trước 2 hôm ĐTV chính thức sang bên FU tiếp cận server), tôi đang ngồi uống trà chanh thì ĐTV gọi điện cho tôi và nói về việc điều tra.
```
ĐTV: Anh sẽ yêu cầu bên FU mở server ra để xem.  
Tôi: Em nghĩ bên FU sẽ tiến hành cover track.  
ĐTV: Không bao giờ được bảo là "em nghĩ" mà phải mở server ra để xem và điều tra, cứ nghĩ thế mà không mở ra xem thì sẽ không lấy được thông tin để điều tra
```
Sau này tôi với ĐTV quá tập chung vào việc điều tra và chứng minh nhóm HieuDM sửa bài thi của tôi nên bỏ qua chi tiết lớn này.

Kinh nghiệm: Khi tiếp cận server và lấy thông tin, phải điều tra xem server đó đã bị cover track hay chưa.  
Sau tất cả những việc bên trên, các bạn có thể dễ dàng giải thích được tại sao khi ĐTV thông báo sang phía FU (chỉ 2 sếp được biết thông tin này) là sẽ chuyển toàn bộ bằng chứng sang cơ quan chức năng để tiến hành truy tố thì LinhTTT lại có được cả số điện thoại của ĐTV để "nói chuyện" và hỏi là "anh có thông tin gì?" sau đó xin gặp mặt vào ngày hôm sau.  
Nếu C50 hay tổ chức nào đó tiến hành tiếp cận cái server để lấy thông tin điều tra thì đều thấy rằng tôi không có dấu hiệu bị sửa bài -> Thằng phanledaivuong chém gió.  
Đến đây thì tôi mới bắt đầu bóc tách được toàn bộ thông tin. Đúng là "binh pháp yếm trá" Nhưng "hạ hồi sẽ rõ". Dù có "yếm trá" đến bao nhiêu thì "hạ hồi" cũng sẽ bị lộ. Vì thế khi tôi hỏi sao ĐTV điều tra được việc gì thì ĐTV hay nói: "Muốn người khác không biết trừ khi mình đừng có làm."

* * *

25 Jun 2012:  
Nhận được thông tin con cá to đã cắn câu (Đây là lúc tôi bắt đầu kết thúc mọi vấn đề)

Tôi bắt đầu xin hoãn thi Resit Final PS và Japanese 3 do không thể chuẩn bị tốt nhất để thi. Các bạn có thể thấy là trong thời gian 1 tháng rưỡi tôi phải điều tra và phân tích những thông tin như thế nào, có thể thức thâu đêm nghiên cứu và phân tích thông tin và suy nghĩ rất nhiều về lượng thông tin sẽ đưa ra công khai. Vì phải làm những công việc này nên tôi không thể có thời gian và sức lực để theo học bình thường tại trường nên hiện tại tôi đang không học bất cứ 1 môn nào tại trường trong nửa block còn lại của học kỳ này, tôi còn phải về nhà để đi làm thuê kiếm tiền đền bù cho HungNL.

Lần 1: xin hoãn thi tôi có gửi 1 email và được yêu cầu là phải qua trường viết bản cứng để được xem xét.  
Lần 2: tôi ra trường viết đơn với lí do giống hệt trong email thì Trưởng phòng QLĐT không chấp nhận vì lí do không rõ ràng.  
Lần 3: Lí do: Bà nội bị ốm nặng, gia đình gọi điện yêu cầu về gấp, vì là cháu đích tôn nên phải về gấp trên nhà nên không thể tham dự kỳ thi (Viết thế này ý là về nhìn mặt bà nội lần cuối) thì trưởng phòng QLĐT không chấp nhận.

Có thể các bạn sẽ không hiểu tại sao trưởng phòng QLĐT lại không chấp nhận lí do này. Nhưng với tôi thì nó đơn giản là ông trưởng phòng QLĐT thích làm gì thì làm.  
Các bạn có thể tham khảo thêm về các email trả lời của phòng QLĐT:
```
http://ubuntuone.com/7I22YyO4duhd3Ochzkk8NF
or http://www.mediafire.com/?bo9se69g5yrg2b9
```            

pass giải nén: `hvaonline.net`

Thật ra thì với tình hình lúc này thì quyền nằm trong tay của ông Trưởng phòng quản lý và đào tạo nên ông ta có thể thích thì cho các sinh viên đang bị đình chỉ học 1 năm theo học bình thường tại trường FU, và nếu ông ta không thích thì viết đơn xin hoãn thi sang kỳ sau 3 lần cũng không được chấp nhận. Tôi cũng không có ý kiến gì nhiều, Tôi liền đi về Mộc Châu luôn vì tôi còn phải bận phân tích, tổng kết toàn bộ các bằng chứng và thông tin lại để viết bài gửi tới các độc giả đang đọc của tôi, tôi đã bỏ rất nhiều công sức và thời gian (hơn 2 tháng) để thu thập dữ liệu và phân tích, nên dù không thi 2 môn Japanese 3 và PS cũng không đáng là gì so với những công sức, thời gian và tiền bạc tôi đã bỏ ra để điều tra những sự việc này. Ít nhất là PhongNX và đồng nghiệp dù có làm gì cũng không thể làm chậm tiến độ của tôi vì tôi đã xác định ngày sẽ đăng bài này lên hva: Friday, 13 Jul 2012.

Trước đó tôi có nói là nhận được thông tin là con cá to đã cắn câu, Vậy thông tin đấy là gì? Đọc tiếp các bạn sẽ rõ.

Việc đầu tiên mà PhongNX và đồng nghiệp nên làm lúc này là không phải nghiên cứu để phủ nhận những nội dung trong bài viết của tôi, mà PhongNX và đồng nghiệp nên nghĩ cách để trả lời các sếp trong hội đồng quản trị của tập đoàn FPT.  
Tôii xin trích 1 đoạn báo cáo của PhongNX gửi cho 1 sếp tại tập đoàn FPT.
```
Dear anh PPP,  
FU đã ra các quyết định kỷ luật liên quan, trong đó buộc thôi học 2 sinh viên (Hiếu và Linh), đình chỉ 1 năm với Hải và Huyền, cắt tín dụng của Hải 1 năm, đình chỉ 1 học kỳ Trình và Hưng (thi hộ), buộc học lại đóng 100% học phí đối với 15 đối tượng khác
```            

Thông tin tôi được cung cấp là HuyenBTT đang theo học môn Advanced Java tại lớp Java1. (Sau này PhongNX có điều tra gì thì đừng có cố hỏi tôi là sinh viên nào cung cấp thông tin này cho tôi, vì đơn giản là 1 email nặc danh và tôi đã xóa rồi)  
Tiếp tục tôi điều tra và phát hiện được HuyenBTT không chỉ đang theo học tại lớp Java1 mà còn đang theo học tại 1 loạt các lớp sau:
```
Originally Posted by HuyenBTT01407
            
> Software Quality Assurance and Testing (SWQ391) (SE0603, start 2012-06-25)  
> Introduction to Databases (DBI201) (SE0606, start 2012-06-25)  
> Advanced Java (PRJ201) (Java1, start 2012-07-02)  
> Software Requirements (SWR301) (SR1, start 2012-06-25)
```            

Các bạn có thể download thêm các tài liệu sau để xem, tôi thu thập bằng chứng tại cms.fpt.edu.vn (đây là trang cho phép sinh viên login vào để lấy tài liệu học và nộp bài tập cho giảng viên):
```
http://ubuntuone.com/3oZZT97WUsZZ0huPhy9iwD
or http://www.mediafire.com/?ycckwkbwl508zw8
```            

pass giải nén: `hvaonline.net`

Ngoài ra sinh viên HaiPM (là sinh viên cũng đang bị đình chỉ học 1 năm) cũng đang theo học bình thường tại FU
```
Originally Posted by HaiPM01028
    
> Japanese 5 (JPS151) (SE0603, start 2012-06-25)
```            

Việc chỉ nêu số lượng sinh viên bị kỷ luật mà không nêu chính xác tên, hay là 1 cái server khi đọc log không thấy tôi bị sửa bài. Tất cả đều đã được "ai đó" âm mưu và tính toán từ trước vài tháng.  
Tôi chỉ có thể nói là: Thật là ngoạn mục. Đúng là "binh pháp yếm trá" nhưng "hạ hồi sẽ rõ", tất cả các bạn đều đã rõ toàn bộ việc này rồi.

Tôi vẫn luôn thắc mắc liệu: Hiệu Phó PhongNX và đồng nghiệp sẽ trả lời thế nào trước các sếp tại tập đoàn FPT nếu được các sếp hỏi về những sự việc này? Nhưng thật đáng hổ thẹn thay việc này lại xảy ra khi đây là những sếp của 1 công ty con trong 1 tập đoàn rất lớn như FPT, và đặc biệt đây là công ty con về lĩnh vực giáo dục. Nơi được coi là đào tạo ra các FPT-er, là tương lai của tập đoàn FPT, nếu FU thế này thì tuơng lai tập đoàn sẽ đi đâu về đâu? Các sếp con được hưởng lương hàng chục triệu 1 tháng lại làm những việc như thế này. Người điều tra và công khai toàn bộ thông tin này ra lại là 1 sinh viên bình thường và sinh viên đó đã phải bỏ rất nhiều thời gian, công sức và tiền bạc mà không được hỗ trợ từ 1 nguồn nhân lực hay tài chính nào bên ngoài.

Ngẫm thấy 2 ông sếp con này giống như 2 con xe trên bàn cờ tướng có thể nói dọc làm ngang thoải mái, còn tôi thì là 1 người vô danh tiểu tốt, chỉ như 1 con tốt nhỏ bé, và rất nhiều "nước cờ cao tay" đã được 2 con xe sử dụng. Tôi cũng không dám nghĩ tới tình huống tươi đẹp như người ta hay nói khi chơi cờ tướng: "Lỡ nước 2 xe đành bỏ phí, được thời 1 tốt cũng thành công". Liệu 2 con xe còn có thể tung hoành ngang dọc được nữa hay không thì điều này phụ thuộc vào con "tướng". Nếu con "tướng" không thể tìm được những người tài khác để thay thế vị trí của 2 con xe này thì chắc là 2 con xe vẫn có thể ung dung nói dọc làm ngang trên bàn cờ. Nhưng chắc chắn 1 điều là nếu con "tướng" giữ 2 con xe này lại thì với những cách nói dọc làm ngang như thế này thì với 1 con tốt có thể "tướng" sẽ không sao, nhưng sự việc sẽ rất khác nếu chỉ cần thay con tốt bằng 1 con pháo.

Vậy liệu 2 con xe này có tung hoành ngang dọc trước đó hay không? Nếu có thì nó đã làm những gì? ( Những thứ nó đã làm đủ cho tôi có nguồn động lực rất lớn để quyết tâm bỏ mọi thứ tập chung đều tra và phanh phui những sự việc này. Tôi luôn coi thứ đó là việc đã lừa đảo và xử ép hơn 1 nghìn sinh viên), Nếu có thời gian dỗi tôi sẽ viết bài nói thêm về vấn đề này.

---

Sau khi đọc xong bài viết của tôi thì chắc cũng sẽ có vài độc giả thắc mắc về việc tôi đặt tiêu đề là: "Phần chìm của tảng băng trôi"

Đúng như Hiệu phó PhongNX nói: "với FPT thì chó cứ sủa thì đoàn người cứ đi". Tôi đang học tại FU nên tôi sẽ tạm mượn hình ảnh của con chó, nhưng tôi sẽ không dùng hình ảnh của 1 con chó đi bộ trên cạn mà sẽ là 1 con chó biển (hải cẩu). Ở đây, tôi đang thấy rằng Đại học FPT không biết sẽ đi đâu về đâu khi chúng ta thấy những việc làm như trên của 2 sếp con, việc này khiến tôi hình dung ra 1 tảng băng đang trôi. Dưới 1 góc nhìn nào đó (như những chú chim bay lướt qua) thì ta sẽ thấy 1 tảng băng (trắng như những viên đá siêu sạch) đang trôi trên mặt biển, những con chó biển đang nằm phơi nắng với những cái bụng no nê. Nhìn thấy thật giầu có, an nhàn, trong sạch. Nhưng tôi chỉ là 1 chú cá bé nhỏ, nên chỉ nhìn được phần "chìm" của tảng băng trôi này. Và khi nó trôi với ánh nắng của mặt trời thì sẽ bị tan dần, phần băng trên sẽ bị tan hết, những phần "chìm" sẽ dần dần được nổi lên (lộ ra). Và nếu tảng băng cứ trôi tự do thế này mà không trôi về đúng cực của nó thì sẽ có ngày bị tan chảy hết và tảng băng sẽ không còn.

---

### **Truyện giờ mới kể**

Tôi bị kỷ luật ở mức cảnh cáo trước toàn trường như thế nào?

Vào học kỳ Fall2009 (Mùa thu năm 2009) tôi có theo học tại lớp SE0405, trong giờ học môn Introduction to Computing của giảng viên Trần Vinh Thu(ThuTV).
```
http://ubuntuone.com/1X9gx1S7tOhg3Zurd87Gq9
or http://www.mediafire.com/i/?2cdtqoxu17d4bex
```            

Vào thời điểm này thì sinh viên đã bắt đầu thi bằng IT Client (lúc này là version 1, mới có chức năng always on top để tránh sinh viên vào web khi thi), các giáo viên sẽ là người trực tiếp bật IT server cho sinh viên thi. Lúc này account để làm bài thi của tôi có vấn đề không thể login được nên tôi đã xin ra ngoài để reset password. Khi xuống phòng IT của trường (134) thì nhân viên IT yêu cầu tôi lên khu vực tầng 2 khu vực IT support để reset password, tôi lên sảnh tầng 2 thì nhân viên IT ở đây đi vắng mà chỉ có vài sinh viên làm IT support có mặt. Sau rất nhiều lần đi lại giữa tầng 1 và tầng 2, tầng 1 thì không chịu reset và yêu cầu đi tìm nhân viên ở tầng 2, tầng 2 thì đi chơi không có mặt ở nơi làm việc. Tôi đành ngậm ngùi vào lớp, account không login vào được để thi.  
(Xin phép được viết nguyên văn để cho mọi người hiểu sự việc)
```
Tôi lẩm bẩm chửi: "ĐM mấy thằng IT", "ĐM mấy thằng IT đi đâu hết rồi đ** reset password cho tao".  
ThuTV: bạn việt anh ăn nói cẩn thận trong lớp.  
Tôi: Vâng ạ.
```          
```
Originally Posted by Vài phút sau
    
> 1 sinh viên khác: ê Phan Lê mày không làm bài thi à?  
> Tôi: ĐM mấy thằng IT nó đi đéo đâu rồi ý. tao không tìm được để reset password để thi.  
> ThuTV: Tôi nhắc lần cuối bạn việt anh ăn nói cẩn thận  
> Tôi: Vâng ạ, em xin lỗi thầy nhưng tại mấy thằng IT nó không reset password cho em nên em không thi được, lại bị 0 oan. Nên hơi khó chịu  
> ThuTV: cứ ngồi im đến hết giờ, ngày mai tôi cho thi bù. (Vì lúc này IT server là do giảng viên cầm để cho sinh viên thi các bài test nhỏ chứ chưa có phòng khảo thí quản lý vấn đề thi những bài test nhỏ mà chỉ quản lý bài thi cuối kỳ, nên giảng viên nếu muốn có thể cho sinh viên thi lại)
```            

Sau khi cả lớp nộp bài. ThuTV bắt đầu đếm đầu sinh viên trong lớp (trừ tôi), và đếm file `.dat` -> thừa 1 file `.dat`.  
Vậy là đã có 1 sinh viên không đi học, và sinh viên khác đến trường làm kiểm tra hộ. Việc này đã bị ThuTV phát hiện, nhưng có lẽ với những môn khác và với những giảng viên khác thì rất nhiều sinh viên đã "trót lọt". Lúc này ThuTV nói là bản IT server có lưu lại log xem máy nào làm bài thi, nên sẽ dễ dàng tìm được ai làm bài hộ bạn. Cho 5 phút để sinh viên nào làm tự giác đứng dậy thì tội sẽ nhẹ, còn nếu không thì sẽ phạt nặng. Sau đó 2 phút có 1 sinh viên đứng dậy nhận tội. Lúc này ThuTV chỉ cảnh cáo nhẹ và show hàng đống file `.xml` lưu lại log. Tôi đã biết được file `.xml` có vai trò như thế nào từ thời điểm này và nó lưu lại những thông tin gì.

Đúng là may có các sinh viên không đi học và làm bài kiểm tra hộ nhau nên mới "thăm dò" được rất nhiều thứ từ IT server.

Ngày hôm sau: 1 nhân viên của trường lên lớp học yêu cầu tôi viết bản tường trình về sự việc ngày hôm qua. Ngớ người ra không hiểu viết về cái gì. Mấy sinh viên ở lớp cười nói về vụ nói bậy trong giờ ThuTV. Sinh viên nói lẩm bẩm có 3 từ "ĐM" mà lại vâng dạ cẩn thận với thầy giáo thì vô lễ cái gì? Không viết.

Sau 1 hôm: Nhân viên lại lên hỏi bản tường trình.

> Trả lời: Viết tường trình về việc gì?   
> Nhân viên: Vô lễ với giảng viên trong giờ học.   
> Trả lời: Em không vô lễ với giảng viên nên em không viết.        
> Nhân viên: Thế thì viết tường trình lại việc hôm qua.  
            

Sau 2 hôm: Nhân viên lên hỏi bản tường trình.
> Trả lời: Em viết rồi nhưng quên không mang.   
> Nhân viên: Thế thì mai cũng được.  
>  Trả lời: vâng ạ  
            

Sau 3 hôm: Nhân viên không lên thu.

Sau 4 hôm: Nhân viên lên hỏi bản tường trình.
> Trả lời: Hôm qua em mang đi thì thầy không lên thu, hôm nay em lại để quên ở nhà rồi.   
> Nhân viên: Thế thì phải đi tìm thầy để nộp chứ?   
> Trả lời: Em biết thầy ở chỗ nào mà tìm?  
            

Sang tuần sau: Hôm đấy đau bụng đi về sớm, cuối giờ nhân viên lên lớp viết biên bản:  
Trong biên bản ghi tội: Vô lễ với giáo viên.  
Có lớp trưởng lớp SE0405 là Vũ Văn Trung (`TrungVV01438@fpt.edu.vn`) ký nhận vào biên bản.

Vài hôm sau, khi đang học thì nhân viên lên đọc quyết định kỷ luật ở mức cảnh cáo trước toàn trường do hiệu trưởng Lê Trường Tùng ký.  
Tôi không thắc mắc bất cứ gì về quyết định kỷ luật này và việc hiệu trưởng Lê Trường Tùng ký quyết định kỷ luật tôi vì trong biên bản tại lớp có lớp trưởng ký có ghi là vô lễ với giáo viên nên khi có biên bản đầy đủ hiệu trưởng sẽ ký quyết định là chuyện bình thường và đúng nguyên tác. Lúc này tôi nghĩ mức kỷ luật này giống như việc viết bản kiểm điểm ở cấp 3 nên cũng không thắc mắc gì thêm. Khi đọc quyết định kỷ luật nhân viên có dặn: "BỊ KỶ LUẬT Ở MỨC CẢNH CÁO TRƯỚC TOÀN TRƯỜNG NẾU TRONG VÒNG 6 THÁNG EM PHẠM THÊM 1 TỘI NÀO THÌ SẼ BỊ ĐÌNH CHỈ HỌC 1 NĂM". Tôi: vâng ạ.

Mấy hôm sau có gặp 1 giảng viên nữ(GVN)
```
GVN: Bạn Việt Anh mới bị cảnh cáo trước toàn trường à?  
Tôi: Vâng ạ, sao cô biết thế ạ.  
GVN: Cô nhận được email, bị cảnh cáo trước toàn trường là sẽ gửi email cho nhân viên toàn trường mà. Thế vô lễ với thầy giáo nào thế?  
Tôi: Em ngồi chửi IT trong giờ học ý mà cô.  
GVN: Thế à.
```            

Vì vậy nên có thể có 1 cách để xác nhận lại nhóm 5 sinh viên hành hung tôi có cảnh cáo trước toàn trường hay không thì chỉ cần là nhân viên FU là có thể biết được. Nếu ai là giảng viên FU thì có thể email riêng cho tôi về vấn đề này, tôi hứa sẽ anonymous thông tin của người cung cấp.

* * *

Sáng nay, tôi vừa nhận được 1 email từ 1 địa chỉ gmail(nhìn liếc qua như `"1 đoạn mã md5"@gmail.com`) gửi đến email của tôi. Sau khi copy các nội dung cần thiết tôi đã xóa email này khỏi hòm thư cũng như thùng rác của tôi. Tuy nhiên tôi vẫn không đăng tải luôn vào buổi sáng hay buổi trưa mà vẫn hi vọng biết đâu sẽ có thêm 1 người đồng cảm với mình. Nên tôi đợi đến tối rồi mới đăng bài 1 lượt (Thường sẽ vào 8h tối)

Người viết email này nói rằng không có email nào trong thời gian nhóm sinh viên HieuDM hành hung tôi đến nay nói về vấn đề các sinh viên bị kỷ luật, và cho đến nay vẫn không có 1 email nào nói về vấn để kỷ luật các sinh viên qua đợt xử lý vừa qua. Để tăng độ tin cậy người gửi bài có kèm thêm những thông tin sau:

> Từ: Tùng, (BGH) Lê Trường \<tung@fpt.edu.vn\>  
> Ngày: 13:22 Ngày 25 tháng 1 năm 2011  
> Chủ đề: Re: Thông báo về việc cập nhật LOGO mới trên các tài liệu ISO  
> Đến: nguyen thi kieu oanh \<oanhntk@fpt.edu.vn\>, Huynh Tan Chau \<chauht@fpt.edu.vn\>, Nguyen Xuan Phong \<phongnguyen@fpt.com.vn\>, Nguyen Khac Thanh \<thanh@fpt.com.vn\>, Tran Ngoc Tuan \<tuantn@fpt.com.vn\>  
>             
> Dear Oanh,  
> BGH đã quyết định tái tổ chức lại FU ĐN để nâng cao hiệu quả hoạt động. Trong tổ chức mới, sẽ không còn cấp Ban, điều này ảnh hưởng đến vị trí Quyền trưởng Ban Đảm bảo của Oanh. Các bộ phận thuộc Ban đảm bảo trước đây như Hành chính, ICT, Thư viện, Nhân sự, Tài chính sẽ do Viện trưởng quản lý trực tiếp, không qua cấp Ban nữa.  
> Hiện nay chưa có phương án bố trí công việc, vị trí của Oanh trong cơ cấu tổ chức mới.  
>            
> Trong thời gian tái tổ chức (từ nay đến 28/2/2011) và chưa bố trí được công việc, Oanh vẫn hưởng lương Quyền trưởng ban, tuy nhiên không còn chức năng điều hành các bộ phận thuộc Ban như trước đây. Oanh nhanh chóng thu xếp để bàn giao các công việc đang nắm, đang thực hiện liên quan đến đảm bảo Hành chính, ICT, Thư viện, Nhân sự, Tài chính. Thời gian và đầu mối, người nhận bàn giao sẽ do anh Châu chỉ đạo trực tiếp, đảm bảo sao cho công việc chung của FU ĐN không bị ngưng trệ.  
            
> Tùng
---
> From: Oanh, Nguyen Thi Kieu (FUDN) \<oanhntk@fpt.edu.vn\>  
> Sent: Tuesday, March 08, 2011 12:03 PM  
> To:  
> CC: Nguyen Xuan Phong; Nguyen Khac Thanh; Tran Ngoc Tuan; ; Huynh Tan Chau  
> Subject: Thư đề xuất from OanhNTK - FUDN  
            
> Kính gửi anh Tùng – Hiệu trưởng,  
> Cùng các anh chị Ban Giám hiệu,  
> Em Oanh FUDN kính viết mail báo cáo BGH đến thời điểm này em đã hoàn thành công tác bàn giao như chỉ đạo. Em cũng đã có mail đề xuất (chỉ gửi riêng anh Tùng) ngày 15/2/2011 về trường hợp công việc của em nhưng không thấy anh trả lời. Em không biết có phải email đó anh Tùng có nhận được hay không nữa.  
> Nay trách nhiệm em đã hoàn tất, thời hạn 28/2/2011 tái tổ chức đã qua, thời gian chưa bố trí được công việc cho em đến nay đã bước sang tuần thứ 2 của tháng 3/2011, kính đề nghị BGH có ý kiến trao đổi cụ thể để em xác định công việc của mình. Mong BGH xem xét đến hoàn cảnh hàng ngày em vẫn phải đến cơ quan đúng nội quy lao động trong khi chỉ chờ đợi, thật khó cho em.  
> Kính mong BGH xem xét. Xin chân thành cảm ơn.  
    
> Regards,  
> Nguyễn Thị Kiều Oanh  
> FPT University – Danang Campus  
> Add: 143 Nguyễn Lương Bằng, Liên Chiểu, Đà Nẵng  
> Tel: 0511 373****  
> Mobile: 091414****  
> Email: /  
> YM!: kieuoanh****@    
---
> From: Oanh, Nguyen Thi Kieu (FUDN)  
> Sent: Fri, Mar 18, 2011 at 9:40 AM  
> To: , Huynh Tan Chau \<chauht@fpt.edu.vn\>  
> Cc: "FU.DN" \<fu.dn@fpt.edu.vn\>, ,  
> Subject: ĐƠN KIẾN NGHỊ  
            
> CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM  
> Độc lập – Tự do – Hạnh phúc  
> ______________________  
> 
> ĐƠN KIẾN NGHỊ  
> 
> Kính gửi:   
> \- Ban Giám hiệu trường Đại học FPT  
> \- Ông Viện trưởng Viện Công nghệ Phần mềm Đà Nẵng  
    
> Tôi ký tên dưới đây là Nguyễn Thị Kiều Oanh, nguyên Trưởng Ban Đảm bảo FUDN, viết đơn kiến nghị các cấp lãnh đạo xem xét giải quyết trường hợp chờ bố trí công việc của tôi.  
> Sau khi ban hành Quyết định số 38/QĐ-ĐHFPT ngày 24/01/2011 về việc tái cơ cấu tổ chức cơ sở đào tạo của trường đại học FPT tại Đà Nẵng và sau đó Hiệu trưởng chỉ đạo tôi hoàn tất bàn giao công việc, tôi đã chấp hành thực hiện xong đúng thời hạn. Biên bản bàn giao đã cho thấy kết quả công việc tôi hoàn thành và đóng góp cho đơn vị trong thời gian qua với tinh thần trách nhiệm cao.      
> Từ thời điểm hoàn tất bàn giao đến nay đã hơn nửa tháng, với niềm tin vào sự sáng suốt, công minh của lãnh đạo nhà trường, tôi đã nhiều lần gửi thư điện tử đề xuất và kiến nghị về việc trao đổi đàm phán về tương lai công việc của tôi. Thế nhưng cho đến nay BGH và ông Viện trưởng vẫn im lặng, né tránh, cố ý xúc phạm tôi, buộc tôi đến văn phòng chờ đợi trong suốt gần 2 tháng nay, ngày càng trở nên chán nản, bất bình.  
> Đến nay tôi xin chính thức viết đơn kiến nghị này gửi BGH và ông Viện trưởng, là những vị trí có trách nhiệm giải quyết cho tôi vấn đề công việc đã ghi rõ trên hợp đồng lao động (giữa tôi và ông Viện trưởng Viện CNPMĐN) và Quyết định bổ nhiệm (của Hiệu trưởng trường ĐH FPT), không có lý do gì mà tiếp tục kéo dài tình trạng hàng ngày tôi phải đi rất xa để đến văn phòng mà không làm việc.  
> Trong thời hạn 7 ngày kể từ ngày gửi đơn xin các cấp lãnh đạo xem xét giải quyết nếu không được giải quyết thỏa đáng tôi buộc phải xin cứu giúp từ Sở Lao động TBXH và UBND thành phố Đà Nẵng, đồng thời gửi báo cáo Bộ GD&ĐT cùng các cơ quan liên quan.  
> Tôi hy vọng rằng một đơn vị đào tạo trong hệ thống giáo dục quốc gia như trường ĐH FPT sẽ có giải pháp trong trường hợp cá nhân tôi đúng tiêu chuẩn hành xử đạo đức và tuân thủ luật pháp, các cấp lãnh đạo của đơn vị cần phải có trách nhiệm với các công bố và cam kết trước xã hội của nhà trường.  
> Kính mong được xem xét.  
    
> Đà Nẵng ngày 18 tháng 3 năm 2011  
> Kính đơn,  
> Nguyễn Thị Kiều Oanh  
> 
> @ Tôi xin gửi thư này đến các anh chị các bạn đồng nghiệp để làm rõ thông tin nội bộ và kêu gọi sự chia sẻ với hoàn cảnh một thành viên trong tổ chức như tôi: lúc nào thì nhận quá nhiều những lời hoa mỹ khoa trương, lúc nào là phải chịu đựng thái độ cố ý xúc phạm, gây tổn thương?  
> Xin lỗi nếu email này làm phiền các anh chị.
---            

> From: Dnvedau Fu  
> To: , ,  
> Date: Fri, Mar 18, 2011 at 11:32 AM  
> Subject: NHÂN ĐỌC ĐƠN KIẾN NGHỊ CỦA BÀ NGUYỄN THỊ KIỀU OANH  
>            
> NHÂN ĐỌC ĐƠN KIẾN NGHỊ CỦA BÀ NGUYỄN THỊ KIỀU OANH. NGUYÊN TRƯỞNG BAN ĐẢM BẢO FUDN.  
> TRƯỚC HẾT, TÔI XIN GỬI LỜI CHIA SẺ VÀ CẢM THÔNG ĐẾN BÀ OANH, MỘT NGƯỜI ĐỒNG NGHIỆP, MỘT THÀNH VIÊN CỦA FU NÓI CHUNG VÀ MỘT ĐỒNG ĐỘI TRONG FUDN NÓI RIÊNG. MỘT NGƯỜI CÓ NĂNG LỰC THỰC SỰ ĐỂ CÓ THỂ GÓP MỘT PHẦN THÀNH CÔNG CHO FUĐN.  
> THIẾT NGHĨ CHO CÙNG VÀ NHIỀU LẦN TỰ ĐẶT CÂU HỎI CHO CHÍNH MÌNH VÀ CHO CHÍNH NHỮNG AI ĐÃ TỪNG LÀM VIỆC VỚI ÔNG VIỆN TRƯỞNG VIỆN CNPM ĐÀ NẴNG. NẾU NÓI THẲNG THẮN VÀ DÙNG TỪ CHO CHÍNH XÁC THÌ ĐƯỢC XEM NHƯ MỘT LOẠI "SÂU BỌ".  
>    
> THƯA CÁC ANH CHỊ ĐÃ ĐẾN LÚC CÁC ANH CHỊ CẦN THAY THẾ, NẾU CÁC ANH CHỊ MUỐN FU TỒN TẠI VÀ VỮNG MẠNH Ở ĐN. CHÚNG TÔI RẤT MONG MUỐN RẰNG NƠI CHÚNG TÔI ĐẾN LÀM VIỆC LÀ ĐỂ CỐNG HIẾN CHO ĐƠN VỊ MÀ CHÚNG TÔI LÀM VIỆC VÀ GÓP MỘT PHẦN XÂY DỰNG SỰ THÀNH CÔNG. CHÚNG TÔI MUỐN LÀM VIỆC ÁP LỰC CÔNG VIỆC CHỨ KHÔNG PHẢI ÁP LỰC VỀ TÌNH THẦN. CHÚNG TÔI MUỐN MỘT VỊ LÃNH ĐẠO SÁNG SUỐT LÃNH ĐẠO LÁI CON TÀU FUNĐN ĐẾN ĐÍCH THÀNH CÔNG CHỨ KHÔNG MUỐN MỘT VỊ "SÂU BỌ" LÃNH ĐẠO SUỐT NGÀY LÔI KÉO ĐỒNG MINH TẠO PHE PHÁI, DỰNG THỦ ĐOẠN ĐỂ LÁI CON TÀU FUDN THEO PHƯỚNG HƯỚNG CÁ NHÂN ĐỂ ĐỘC ĐOÁN, TRỤC LỢI CHO CÁ NHÂN, ĐỂ TRẢ THÙ VÀ ĐE DỌA TINH THẦN ĐỒNG ĐỘI.  
>     
> TẠI SAO KHÔNG PHẢI THAY THẾ? TẠI SAO VẪN ĐỂ CON "VIRUS" NÀY TIẾP TỤC LÀM NHƠ BẨN ĐẾN VẬY?  
> XIN THƯA CÁC ANH CHỊ CON "VIRUS" NÀY KHÁ ĐẶC BIỆT. NẾU XÉT VỀ "SÂU BỌ" THÌ KHÔNG THÍCH HỢP MÔI TRƯỜNG THÌ PHẢI DI CHUYỂN ĐỂM TÌM MÔI TRƯỜNG THÍCH HỢP ĐỂ SỐNG HOẶC BẢN NĂNG PHẢI TỰ THAY ĐỔI MÌNH ĐỂ PHÙ HỢP MÔI TRƯỜNG SỐNG NHƯNG CON "VIRUS" NÀY NÓ "CHUI RÚC" NHƠ BẨN MỌI NƠI ĐỂ TỒN TẠI. ĐAY ĐƯỢC XEM LÀ LOẠI VIRUS MÀ XÃ HỘI NGÀY NAY CẦN "TIÊU DIỆT".  
>    
> CUỐI THƯ MONG CÁC ANH CHỊ LƯU Ý: TRONG DÒNG MÁU FU ĐANG CÓ MỘT CON "VIRUS' ĐẶC BIỆT. COI CHỪNG NÓ CẮN LÚC NÀO KHÔNG HAY.
---            

Đây là email tôi nhận được chứ không phải tôi đã hack chiếm quyền quản lý email của 1 nhân viên nào đó tại FU. Để tránh FU lợi dụng chi tiết này để tiến hành kỷ luật hay đuổi học tôi. Vì đến bây giờ khi đăng toàn bộ thông tin lên hvaonline.net tôi không vi phạm bất cứ qui định nào của FU. Nếu phía FU sắp tới sửa qui định là cấm sinh viên tiết lộ các bí mật của trường lên internet thì tôi sẽ không đăng bài lên hvaonline.net hay bất cứ diễn đàn và trang mạng xã hội nào cả.

Theo như thông tin của chủ email kia cung cấp cho tôi: Không có 1 email nào gửi cho nhân viên toàn trường về việc cảnh cáo trước toàn trường nhóm sinh viên hành hung tôi. Vậy liệu PhongNX đã kỷ luật (mức cảnh cáo trước toàn trường trở lên) tất cả những sinh viên này và không gửi email đến nhân viên toàn trường hay là không có chuyện kỷ luật bất cứ sinh viên nào thì tôi cũng không thể có câu trả lời tới độc giả của tôi bởi vì với cách làm việc thế này của PhongNX thì rất khó để tôi có câu trả lời gửi tới bạn đọc.

Tôi có đọc được rất nhiều ý kiến chỉ trích tôi. Nhưng có lẽ các bạn vẫn chưa hiểu hết bài viết của tôi. Tôi viết bài này để đề cập tới vấn đề: "CÁC SINH VIÊN ĐANG BỊ ĐÌNH CHỈ HỌC TẬP 1 NĂM VẪN THEO HỌC BÌNH THƯỜNG TẠI TRƯỜNG". Tôi đã nói từ trước là không bao giờ tôi viết bài hay đưa thông tin này lên nếu như vụ việc được giải quyết đúng như thế. Nhưng sau khi ĐTV đi về phía tập đoàn thì các sinh viên bị đình chỉ học 1 năm vẫn theo học bình thường tại trường? Vậy thì FU (thật ra là "ai đó") đang làm cái gì? Các bạn có thể thoải mái chỉ trích tôi nếu các bạn thấy ở 1 trường đại học khi các sinh viên đang bị đình chỉ học 1 năm vẫn theo học bình thường tại trường là chuyện bình thường.

Tôi không đảm bảo nội dung của các email này do có người nào đó gửi những nội dung này cho tôi:

1.  Kể từ khi bị FU kỷ luật về hành vi sử dụng phần mềm trái phép can thiệp vào server trường, tôi không tiến hành thăm dò hay có ý đồ tấn công vào server FU. Tôi không chiếm quyền quản lý email nào của bất cứ 1 giảng viên FU nào.
2.  Đây là 1 phần trong nội dung email có người gửi cho tôi nên tôi chia sẻ, tôi không có quyền login vào và đọc trộm email của ai đó. Nhưng tôi hoàn toàn có quyền chia sẽ nội dung email mà người khác gửi cho tôi (Cho những người khác cùng đọc những nội dung của email này) và tôi hoàn toàn có quyền xóa nó đi sau khi đọc xong và chia sẻ cho mọi người 1 phần nội dung của nó.
3.  Do không đảm bảo những nội dung này có chính xác hay không? liệu có thật hay chỉ là do người nào đó viết ra những nội dung email này rồi gửi cho tôi nên tôi sẽ chia sẻ những nội dung này lên hva. Chỉ cần phía FU có khẳng định toàn bộ nội dung những email này là thật tại website chính của trường: fpt.edu.vn và yêu cầu tôi xóa những nội dung này đi + gửi 1 email cho tôi để nhắc nhở về việc xóa nội dung này đi thì ngay lập tức tôi sẽ nhờ các moderator xóa bài này của tôi đi (post bài trên diễn đàn nhờ các moderator xóa, chứ không liên lạc riêng). Bởi vì tôi tôn trọng quyền riêng tư của người khác, nếu như nội dung những email này là thật thì tôi sẽ xóa bài viết này đi, nhưng mà phải được thông báo trên kênh chính thức của trường là fpt.edu.vn. Còn nếu không thì có thể nội dung này do người nào đó biên soạn ra và không có thật, nên việc tôi chia sẻ nội dung email người khác gửi cho tôi hoàn toàn không vi phạm gì pháp luật cả.
4.  Tôi không thích đưa ra những thông tin, bằng chứng theo kiểu "tiêu cực" như "nội dung những email này". Nhưng đây là tấm lòng của độc giả đã gửi gắm cho tôi nên tôi chia sẻ cho các bạn cùng đọc (ít nhất đã có 1 độc giả đồng cảm với mình). Nếu lần sau tôi nhận được những email thế này tôi sẽ cân nhắc kỹ trước khi chia sẻ. Bởi vì tôi biết các bạn đọc tại hva cũng không muốn đọc thông tin, bằng chứng như "nội dung những email này."
5.  Có nhiều bạn đọc nói về việc cần có thêm bằng chứng để mọi người tin vào câu truyện? Vậy thì tôi cần phải hack vào server của FU để lấy bằng chứng ư? Tôi không có khả năng để hack được vào server của FU và nếu có khả năng tôi cũng không hack để lấy bằng chứng ra vì chỉ cần vậy là tôi sẽ bị đuổi học hoặc sẽ sẵn sàng bị mang ra truy tố trước pháp luật. Việc đưa nội dung những email này lên hva đối với tôi cũng là hơi quá đáng, nhưng có vẻ chỉ có "1 vài" người quan tâm và đồng cảm ngoài ra còn cung cấp thông tin những thông tin như email này cho tôi nên đây có thể sẽ là lần đầu tôi chia sẻ cùng bạn đọc nội dung những email tôi nhận được và cũng là lần cuối cùng tôi chia sẻ thông tin và bằng chứng mà tôi đánh giá là "tiêu cực" như thế này.

Vấn đề cung cấp bằng chứng để chứng minh 1 việc gì đó trước công luận là 1 việc rất khó khăn. Không thể chiều lòng tất cả mọi người.  
Việc hack vào server FU để lấy bằng chứng là 1 việc nằm ngoài khả năng của tôi. Tôi chỉ có thể liệt kê ra các chi tiết và chuyện đã xảy ra cho mọi người xem xét?  
Vậy liệu tôi có đủ khả năng để đưa bằng chứng tới các bạn, khi đọc bài viết có đầy đủ bằng chứng các bạn sẽ nghĩ thế nào: "ôi dào cái thằng đấy lại giờ trò đi hack người ta để lấy bằng chứng thế thì hơn gì người ta" hay là ngay lập tức tôi sẽ bị truy tố vì vi phạm pháp luật và có thể ngồi tù?  
Các bạn có thích đọc và xem những bằng chứng như nội dung những email như trên không? Tôi không có khả năng để hack và làm những việc như thế, email trên chỉ là 1 phần nội dung email có người gửi cho tôi (và tôi đã xoá). Nhưng nếu có người gửi cho tôi bằng chứng đầy đủ của tất cả chuyện trên mà tôi đánh giá rằng nó là bằng chứng "tiêu cực" thì tôi cũng sẽ không thể gửi đến bạn đọc để tránh người khác nghĩ tôi đã hack vào server FU và chụp cho tôi cái "mũ đen".

Gửi tới ai đó.  
Hôm nay đọc qua vài bài viết trên mạng, có 1 bài viết làm mình suy nghĩ nhiều nhất. Đó là bài viết của Researcher AAA.

> AAA wrote:   
```  
P/s: đến giờ tớ vẫn nhớ và cảm ơn 1 anh bạn đồng nghiệp khi chạy vào, lặng lẽ cầm cái E72 của tớ, bật cái recorder lên, để trên bàn.. Và sau khi tớ thắc mắc "sao thế?" thì câu trả lời là "Củi lửa, coi chừng có ngày nó cắn lại thì đừng hỏi tại sao lại đau".. Tiếc là cái điện thoại mất mất rồi.. 
```
Có 1 vấn đề lớn là tôi đã cắt bớt cuộc nói chuyện riêng với ĐTV ở lần gặp ngày 7 Apr 2012,
```
Tôi : nếu sắp tới em với FU có chuyện gì thì liệu có ảnh hưởng đến quan hệ của anh em mình không?  
ĐTV : Mọi việc đã xong rồi mà? sao chú không để nó xong?  
Tôi : Thì em dự đoán là có thể tương lai sẽ có vấn đề.  
ĐTV : Chú là thánh à hay sao mà dự đoán trước được.  
Tôi : Thì em biết là sẽ có chuyện?  
ĐTV : Chuyện gì vậy? Chú là người không ngay thẳng à nên mới không nói.  
Tôi :... (mới bắt đầu cuộc hội thoại trên, và trong cuộc hội thoại tôi đã nói về vấn đề kỳ sau HuyenBTT sẽ vẫn đi học bình thường nhưng ĐTV bảo sẽ không có chuyện đó)  
```            

Nên vấn đề tôi nghĩ bụng và "rình" HuyenBTT đi học là chuyện bình thường. Vì trước đó tôi đã nói với ĐTV nhưng ĐTV vẫn tin là sếp bên FU sẽ không bao giờ làm như thế. ĐTV luôn có lòng vị tha và tin người khác mà. AAA không biết được tôi đã nói chuyện gì với ĐTV ở lần gặp cuối thì đừng có phán xét kiểu đấy.

Vấn đề AAA nói là KKK đề phòng: "coi chừng có ngày nó cắn lại thì đừng hỏi tại sao lại đau". Vấn đề tôi đề cập tới không phải là việc ĐTV đã xử lý thế nào. Vì với lượng bằng chứng như thế thì xử lý thế là hợp tình hợp lý rồi và tôi không thắc mắc gì về việc làm ĐTV. Vấn đề tôi đang nói tới là việc FU để các sinh viên bị đình chỉ học 1 năm theo học bình thường. Chả lẽ tôi viết 1 bài dạng: "Đại học FPT, có các sinh viên đang bị đình chỉ học 1 năm và đang theo học bình thường chứ không phải đang bị đình chỉ". Viết thế thì mọi người sẽ không hiểu được nội dung câu truyện nên tôi phải kể chi tiết chứ không có khai nhận như DucNT khi khai ra 3 sinh viên khác và bỏ qua cho LinhTTT.

Về vấn đề KKK nói có ngày tôi "cắn" lại? Tôi đã "cắn" lại ĐTV chưa? Hay tôi đang viết bài để đề cập đến việc FU cho sinh viên đang bị đình chỉ học 1 năm theo học bình thường? Là 1 người khôn ngoan, được ĐTV đánh giá cao thì AAA nên biết cách đọc và hiểu vấn đề. Chả lẽ tôi ngồi im nhìn các sinh viên đình chỉ học 1 năm đi học bình thường? Như trường chưa xử lý? Để cho 1 vài đối tượng nghĩ rằng tất cả những mưu kế và thủ đoạn đó là hoàn hảo không ai biết được?

Vấn đề KKK bật recorder và ghi âm để phòng tôi "cắn": Tại sao ĐTV gọi AAA, KKK, ... Vào để anh em cùng ở diễn đàn HVA nói chuyện làm quen với nhau, thế thì chỉ cần nói chuyện vui và hỏi tên hay như nào đó là đủ? Tại sao trước đó tại HVA có 1 nick vừa lập rồi nói chuyện tôi đã từng flood server FU. Sau đó KKK bật recorder từ trước và đi vào rồi hỏi tôi về vấn đề này? Nếu chỉ là nói chuyện làm quen thì cần gì phải bật recorder từ trước? Hỏi kiểu anh em tâm tình với nhau rồi bí mật ghi âm lại? Sau đó AAA đi lại ngồi gần tôi rót 1 chén nước chè uống rồi đặt điện thoại lên bàn để ghi âm. Khi ĐTV là 1 người làm việc cẩn thận và minh bạch không làm việc này thì những người dưới quyền ĐTV âm thầm làm việc này với tôi? Tại sao tôi với ĐTV làm việc lại không cần phải 1 recorder nào? AAA cần phải xác định rõ vấn đề xem tôi đang "cắn" ĐTV hay là tôi đang nói về việc các sếp tại FU làm ăn thế nào? FU là FU và tập đoàn FPT là tập đoàn FPT. Không thể lấy cả 1 FU hay thậm chí cả tập đoàn FPT ra để làm bia cho 1 "ai đó".

Tôi muốn hỏi KKK là liệu KKK thấy tôi đã "cắn" KKK chưa? Tôi có nói là KKK đã bị dính malware của tôi và tôi bạch hóa KKK chưa hay sao KKK lại nói là phòng tôi cắn? và AAA rất tâm đắc với điều đó. Đều là anh em ở HVA, tôi chả có khả năng gì cả. Còn AAA và KKK đều là những người có tài năng, là moderator, researcher. Vì vậy tôi nghĩ AAA và KKK nên sống thế nào để cho mọi người dễ nhìn mặt nhau. Việc của tôi với FU là việc của tôi với FU, đừng có lôi nó vào với việc tôi và ĐTV và nói là tôi đã "cắn". Là con người nên rạch ròi những thứ đó. Nhất là với những moderator, researcher thì là người người có khả năng logic tốt nên cần phải biết điều này. Đừng đánh đồng mọi thứ với nhau.  
Việc KKK âm thầm ghi âm lại và 4 anh em tâm tình nói chuyện sau đó hỏi tôi đã từng flood server FU có đúng không? Tất nhiên câu trả lời là không. Việc này của KKK dễ làm cho tôi thấy KKK đang có ý định gì đó với tôi hơn là đề phòng tôi "cắn". VÌ làm việc minh bạch sẽ không bao giờ tôi có thể "cắn" lại được hay phải lo bị tôi "cắn".

* * *

**@phanledaivuong** ([https://voz.party/d/124633-dai-hoc-fpt-phan-2-phan-chim-cua-tang-bang-troi/275](https://voz.party/d/124633-dai-hoc-fpt-phan-2-phan-chim-cua-tang-bang-troi/275)) 
> *Replying `@inufan` (Linh Gấu Bông) - HươngLTT:*

Chả có gì là đi quá xa ở đây cả, vấn đề chính ở đây là những "ai đó" đã làm có logic với nhau để dẫn đến việc bây giờ đang xảy ra: Sinh viên bi đình chỉ học 1 năm đang theo học bình thường tại trường (Điều này mình đã rất nhiều lần đề cập với ĐTV nhưng đều bị bác bỏ vì ĐTV tin tưởng vào các sếp tại FU sẽ không làm thế).

Tiếp tục về vấn đề khả năng nhé: Mình cũng đã nói rồi, đến cả việc deobfuscator mình cũng nhờ người giúp mà. Có thể đó chỉ là 1 sinh viên khóa 2,3 đang học lại và đến bây giờ vẫn chưa được đi thực tập, nhưng người đó sau 1 lần nói chuyện với mình đã học và nghiên cứu về vấn đề này, sau đó làm những công việc này cùng mình. Điều đó có tuyệt vời hơn dùng 1 sinh viên trường đi thi ACM hay imagine cup để làm việc này không?

Vấn đề chính ở đây không phải là bạn tự tay làm toàn bộ hay tất cả, mà là bạn cần biết kết hợp tất cả những điểm mạnh của người khác lại để giải quyết công việc, 1 đàn kiến nhỏ bé có thể thắng được 1 con voi trong truyện kiến giết voi mà. Mình đang ngồi tại Mộc Châu và toàn bộ những công việc này đã được hoàn thành và đăng tải trên internet, chả lẽ bạn muốn mình phải có mặt tận lớp để kiểm tra HuyenBTT và HaiPM đang ngồi học ở lớp nào à? Đơn giản là mình sẽ tìm kiếm người làm việc đấy hộ mình. Steve Jobs không lấy cát rồi làm 1 loạt công đoạn để tạo thành cái kính Iphone rồi sau đó tự tay làm từng phần cái Iphone để tạo ra 1 chiếc Iphone hoàn chỉnh đâu bạn ạ. Vậy bạn đang lợi dụng việc Steve Jobs không tự tay làm từng cái kính Iphone để phủ nhận việc Iphone là sản phẩm tốt được rất nhiều người mơ ước muốn có (Mình dùng Nokia 1110i).

Thật ra tất cả những người phủ nhận và lôi những điểm yếu của mình đều nằm trong tầm "mong muốn" của mình, vì các bạn không biết được rằng các bạn đang up topic của mình lên. Vấn đề không phải mình cần mọi người nghĩ mình là 1 người kiểu mẫu mà đơn giản chỉ cần những thứ này được càng nhiều người biết đến càng tốt. Mình luôn ngồi cười rất to khi có những người vào comment như những sinh viên FU vào abcxyz mình vì không có họ có khi topic này đã xuống đến tận trang 100 chứ không phải luôn ở trang 1 của cái diễn đàn này(và khi đó sẽ chẳng có ai biết để đọc)  
Có 1 điều rằng các bạn không thể lôi những vấn đề gì đó của mình để phủ nhận hoàn toàn chuyện này, ít nhất rằng các sinh viên đã bị đình chỉ học 1 năm đã đi học bình thường, nó đập vào mắt các sinh viên đang ngồi cùng lớp. Cần phải biết rằng những kẻ nào đó sẽ phải trả giá, nếu như nhiều người nói rằng tập đoàn FPT đã và đang mục nát từ trên xuống dưới, và những việc này là do cả bộ máy chứ không phải chỉ 1 hay 2 "người" là có thể làm như này. Thì ít ra họ đã phải trả giá bằng việc tất cả mọi người và mọi nơi đều biết những việc làm này của họ.  
Có 1 vấn đề nhỏ ở đây là:

> Hồi đó bạn VA, qua lời miêu tả của Hương, là một người khá hiền lành và dễ thương, còn cá nhân mình thì thấy VA rất nhiệt tình, luôn hết lòng vì bạn bè.

(Đoạn này chắc là Linh viết): Thật ra thì bây giờ vẫn vậy thôi, nhưng mà môi trường FU bây giờ không còn như những năm đầu bạn ạ. Tớ vẫn nhớ bọn bạn hay trêu cậu là người yêu tớ. Hay hồi đấy cậu vẫn còn trẻ con lắm, Cậu nhờ tớ đèo ra ga để về quê, và khi đó cậu yêu cầu tớ ở lại để đi "dạo phố" với cậu tớ không chịu bảo thế giống GAY rồi tớ lấy xe máy phóng thẳng về nhà, cậu đã khóc, tớ thì kệ khóc thì khóc. Có lẽ tớ có 1 trí nhớ tốt phải không? Nhưng cũng chính vì thế nên mới có ngày hôm nay đấy cậu ạ, tớ sẽ kể cho cậu nghe 1 câu truyện nhỏ:

Ngày 25/08/2008. Tại 1 cuộc hội thảo: Hiểu \*\*\* quyết định\*\*\*. Có 1 con vẹt vẫn luôn nói về việc ABCXYZ (Việc này các sinh viên FU khóa 1 -> 4 sau khi đọc xong hết chuyện sẽ hiểu). Sau này do khả năng kém cỏi của con vẹt cùng những con chim khác trong lồng không có khả năng thuyết phục những người khác làm việc đấy, sau đó nó đã chuyển sang bắt buộc.(Vào thời kỳ K3 bắt đầu học học kỳ thứ 3, 1 năm học khi đó chỉ gồm 2 kỳ. Nên bây giờ để chuyển sang giai đoạn OJT thì từ K4 trở đi phải qua 5, còn lại K1,2,3 thì chỉ cần qua 3 nó là ở đây này. Rất nhiều sinh viên không biết tại sao K1,2,3 chỉ cần qua 3 là chuyển sang OJT rồi về trường học tiếp, và đây chính là câu trả lời)

Sau đó nó đòi chuyển từ 7->9 (Sau này chuyển từ 7->5), 1 loạt sinh viên của trường tụ tập với băng rôn và biểu tình trong phạm vi trường để phản đối việc này(đứng đầu là các sinh viên khóa 1,2). Lúc đấy mình không tham gia vì mình nhận thấy các bạn đang làm việc này không khả thi, đơn giản rằng kể từ khi nó chuyển từ option sang bắt buộc là "kẻ nào đó" đã lợi dụng quyền lực để ép buộc kẻ khác vậy nên việc nói lí lẽ với những "kẻ" như thế này là việc vô ích. Mình tự nhủ sẽ có ngày những kẻ này phải trả giá, với những kẻ sử dụng truyền thông để quảng cáo cái gì đó, gây dựng danh tiếng của mình và sợ người khác biết và nói về những "bí mật" của kẻ đó thì đây là cách trả giá tốt nhất rồi.  
Những "kẻ" mà hằng ngày đi khắp nơi quảng cáo và thuyết khách trong khi việc đơn giản nhất là thuyết phục đám sinh viên cũng không được mà sau đó dùng quyền lực để ép buộc thì với mình đơn giản cũng chỉ là những "kẻ" bất tài, và từ trước đến giờ cũng chỉ sử dụng những âm mưu và tính toán như thế này để ngồi lên cái ghế đó.

Còn vấn đề nhiều người hay lợi dụng mình học 8 lần hay 9 lần "3" để hạ thấp mình thì đơn giản họ đã không biết được đằng sau vấn đề là đâu, đằng sau vấn đề đấy là tất cả những thứ này. Với mình đây là 1 bản hợp đồng hỏng, và kẻ nào đó đã vi phạm nghiêm trọng hợp đồng cũng như được coi là lừa đảo vì so nó với ngày 25/08/2008. Mình không giống hơn 1000 sinh viên khác ngoan ngoãn nghe theo sự sắp đặt, và những thứ này theo mình suốt thời gian qua, nó nhắc nhở mình về việc mình đã bị lừa đảo thế nào? Bị những "kẻ" bất tài dùng quyền lực ép như nào. Và mình luôn tự nhủ sẽ có ngày những "kẻ" này phải trả giá. Và bây giờ là lúc đấy. Dù các bạn có suy nghĩ mình như nào cũng được.  
Trước đây bạn có thể thấy mình " hiền lành và dễ thương, rất nhiệt tình, luôn hết lòng vì bạn bè" và bây giờ khi những người mình coi là bạn thì khi gọi mình luôn có mặt nhanh nhất có thể. Còn đối với những việc mình coi là tiêu cực (như việc lừa đảo, ép buộc này) thì mình sẵn sàn đáp lại bằng những việc như thế này. Ai đối xử thế nào với mình thế nào thì mình sẽ đáp lại y hệt.

Sau tất cả những việc này, việc công bố bài viết này thì người duy nhất được quyền chê trách mình là ĐTV vì mình đã tiết lộ các "private conversation". Nhưng mình nghĩ ĐTV sẽ không chê trách được mình vì tất cả những việc này đều được mình báo trước đây 3 tháng nhưng ĐTV không tin (và luôn luôn đánh giá mình là 1 người đa nghi) là nó sẽ xảy ra vì ĐTV nghĩ các sếp FU sẽ không bao giờ làm "trò mèo" này.

Sau nhiều chuyện xảy ra mình bắt đầu nhớ lại 1 phần đề thi vào FPT năm 2008 của mình: "Bạn chỉ có thể đạt được những ước mơ của cuộc đời khi không chú ý đến người khác nghĩ gì về mình". Ít nhất bây giờ ước mơ về những kẻ đó phải trả giá đã xảy ra, những kẻ đó chuyên đi quảng cáo, PR thì bây giờ đã phải trả giá bằng danh dự của những kẻ đó khi toàn bộ những việc làm và âm mưu của những kẻ đó đã được mình bóc mẽ, và công khai toàn bộ tại internet.

Cám ơn Hương và Linh đã quan tâm đến vấn đề này, đọc bài viết, và nhớ đến 1 Phan Lê Việt Anh của 4 năm trước. 1 Phan Lê Việt Anh "hiền lành và dễ thương, rất nhiệt tình, luôn hết lòng vì bạn bè".

* * *

Không có phần 3, không thể tìm thấy trên archive của HVAOnline hay là old voz.
