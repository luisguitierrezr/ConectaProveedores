namespace ssConectaProveedores {
/// <summary>
/// [CustomStructure] NewNotification2 (ndsFNyueeUSa5VZtjZ90nA)
///  <code>ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure</code> that represent
/// s <code>NewNotification2</code> <p>Description: </p>
/// </summary>
// Name: NewNotification2
public partial struct ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure : ITypedRecord<ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure> {
internal static readonly GlobalObjectKey Iduserids = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lDOkfOafuUGRmUZ3+t4MCw");
internal static readonly GlobalObjectKey Idtitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*yr47slB54Eek_p+WtUHkxw");
internal static readonly GlobalObjectKey Idcontent = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sMGjA_SLjUukau7tEqA32w");
internal static readonly GlobalObjectKey Idcategoryclass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vZfmonKae02Hq7sLJldlnQ");

public BasicTypeList<string> ssuserids;

public string sstitle;

public string sscontent;

public string sscategoryclass;


public BitArray OptimizedAttributes;

public ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure() {
OptimizedAttributes = null;
ssuserids = new BasicTypeList<string>();
sstitle = "";
sscontent = "";
sscategoryclass = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
sstitle = r.ReadText(index++, "NewNotification2.title", "");
sscontent = r.ReadText(index++, "NewNotification2.content", "");
sscategoryclass = r.ReadText(index++, "NewNotification2.categoryclass", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure r) {
this = r;
}


public static bool operator == (ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure a, ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure b) {
if (a.ssuserids != b.ssuserids) return false;
if (a.sstitle != b.sstitle) return false;
if (a.sscontent != b.sscontent) return false;
if (a.sscategoryclass != b.sscategoryclass) return false;
return true;
}

public static bool operator != (ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure a, ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure)) return false;
return (this == (ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssuserids.GetHashCode()
 ^ sstitle.GetHashCode()
 ^ sscontent.GetHashCode()
 ^ sscategoryclass.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssuserids.RecursiveReset();
}

public void InternalRecursiveSave() {
ssuserids.InternalRecursiveSave();
}


public ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure Duplicate() {
ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure t;
t.ssuserids = (BasicTypeList<string>)this.ssuserids.Duplicate();
t.sstitle = this.sstitle;
t.sscontent = this.sscontent;
t.sscategoryclass = this.sscategoryclass;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "userids") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".userids")) variable.Value = ssuserids; else variable.Optimized = true;
variable.SetFieldName("userids");
} else if (head == "title") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".title")) variable.Value = sstitle; else variable.Optimized = true;
} else if (head == "content") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".content")) variable.Value = sscontent; else variable.Optimized = true;
} else if (head == "categoryclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".categoryclass")) variable.Value = sscategoryclass; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == Iduserids) {
return ssuserids;
}
if (key == Idtitle) {
return sstitle;
}
if (key == Idcontent) {
return sscontent;
}
if (key == Idcategoryclass) {
return sscategoryclass;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Iduserids.Key.AsGuid) {
return ssuserids;
}
if (attributeKey == Idtitle.Key.AsGuid) {
return sstitle;
}
if (attributeKey == Idcontent.Key.AsGuid) {
return sscontent;
}
if (attributeKey == Idcategoryclass.Key.AsGuid) {
return sscategoryclass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssuserids = new BasicTypeList<string>();
ssuserids.FillFromOther((IOSList) other.AttributeGet(Iduserids));
sstitle = (string) other.AttributeGet(Idtitle);
sscontent = (string) other.AttributeGet(Idcontent);
sscategoryclass = (string) other.AttributeGet(Idcategoryclass);
}
} // ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure
/// <summary>
/// RecordList type <code>NewNotification2List</code> that represents a record list of
///  <code>NewNotification2</code>
/// </summary>
public partial class RL_eab0448114a72cb7e99244586da945d4 : GenericRecordList<ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure>, IEnumerable, IEnumerator {

protected override ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure GetElementDefaultValue() {
return new ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure();
}

public T[] ToArray<T>(Func<ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_eab0448114a72cb7e99244586da945d4 recordList, Func<ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_eab0448114a72cb7e99244586da945d4(ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure[] array) {
  RL_eab0448114a72cb7e99244586da945d4 result = new RL_eab0448114a72cb7e99244586da945d4();
result.InnerFromArray(array);
    return result;
}

public static RL_eab0448114a72cb7e99244586da945d4 ToList<T>(T[] array, Func <T, ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure> converter) {
  RL_eab0448114a72cb7e99244586da945d4 result = new RL_eab0448114a72cb7e99244586da945d4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_eab0448114a72cb7e99244586da945d4 FromRestList<T>(RestList<T> restList, Func <T, ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure> converter) {
  RL_eab0448114a72cb7e99244586da945d4 result = new RL_eab0448114a72cb7e99244586da945d4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_eab0448114a72cb7e99244586da945d4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure> NewList() {
return new RL_eab0448114a72cb7e99244586da945d4();
}


} // RL_eab0448114a72cb7e99244586da945d4
}


namespace ssConectaProveedores {
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Abstractions;
public class RESTNewNotification2 {
[JsonProperty("userids")]
public string[] restuserids;

[JsonProperty("title")]
public string resttitle;

[JsonProperty("content")]
public string restcontent;

[JsonProperty("categoryclass")]
public string restcategoryclass;

public RESTNewNotification2() { }

public RESTNewNotification2(ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure s) {
restuserids = s.ssuserids.Length == 0 ? null : s.ssuserids.ToArray();
resttitle = s.sstitle == "" ? null : s.sstitle;
restcontent = s.sscontent == "" ? null : s.sscontent;
restcategoryclass = s.sscategoryclass == "" ? null : s.sscategoryclass;
}

public static ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure ToStructure(RESTNewNotification2 obj) { 
  ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure s = new ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure();
  if(obj != null) {
  s.ssuserids = BasicTypeList<string>.ToList(obj.restuserids);
  s.sstitle = obj.resttitle == null ? "" : obj.resttitle;
  s.sscontent = obj.restcontent == null ? "" : obj.restcontent;
  s.sscategoryclass = obj.restcategoryclass == null ? "" : obj.restcategoryclass;
  }
  return s;
}

public static RESTNewNotification2 FromStructure(ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure s) { 
  return new RESTNewNotification2(s);
}

}
}
