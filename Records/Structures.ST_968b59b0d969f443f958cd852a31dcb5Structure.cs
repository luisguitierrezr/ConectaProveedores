namespace ssConectaProveedores {
/// <summary>
/// [CustomStructure] NotificationOutput2 (oIcimo39IESqkxfj9gqDEg)
///  <code>ST_968b59b0d969f443f958cd852a31dcb5Structure</code> that represent
/// s <code>NotificationOutput2</code> <p>Description: </p>
/// </summary>
// Name: NotificationOutput2
public partial struct ST_968b59b0d969f443f958cd852a31dcb5Structure : ITypedRecord<ST_968b59b0d969f443f958cd852a31dcb5Structure> {
internal static readonly GlobalObjectKey Idid = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*TsAhLqxPq0qMcQ7Zy1Wa_Q");
internal static readonly GlobalObjectKey Idtitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ZfefiNnyVEu8+bBP2dc3GA");
internal static readonly GlobalObjectKey Idcontent = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*siZu4egInUCmteuloQkjFg");
internal static readonly GlobalObjectKey Idisread = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*g0h_ht+CmkyQhw30EXFiCA");
internal static readonly GlobalObjectKey Idcreatedat = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*II+YRJNdHkWdexUwtR1+rA");
internal static readonly GlobalObjectKey Idcategoryclass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lTW2auPy4UujVMvccYj8tQ");

public long ssid;

public string sstitle;

public string sscontent;

public bool ssisread;

public DateTime sscreatedat;

public string sscategoryclass;


public BitArray OptimizedAttributes;

public ST_968b59b0d969f443f958cd852a31dcb5Structure() {
OptimizedAttributes = null;
ssid = 0L;
sstitle = "";
sscontent = "";
ssisread = false;
sscreatedat = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
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
ssid = r.ReadLongInteger(index++, "NotificationOutput2.id", 0L);
sstitle = r.ReadText(index++, "NotificationOutput2.title", "");
sscontent = r.ReadText(index++, "NotificationOutput2.content", "");
ssisread = r.ReadBoolean(index++, "NotificationOutput2.isread", false);
sscreatedat = r.ReadDateTime(index++, "NotificationOutput2.createdat", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
sscategoryclass = r.ReadText(index++, "NotificationOutput2.categoryclass", "");
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
public void ReadIM(ST_968b59b0d969f443f958cd852a31dcb5Structure r) {
this = r;
}


public static bool operator == (ST_968b59b0d969f443f958cd852a31dcb5Structure a, ST_968b59b0d969f443f958cd852a31dcb5Structure b) {
if (a.ssid != b.ssid) return false;
if (a.sstitle != b.sstitle) return false;
if (a.sscontent != b.sscontent) return false;
if (a.ssisread != b.ssisread) return false;
if (a.sscreatedat != b.sscreatedat) return false;
if (a.sscategoryclass != b.sscategoryclass) return false;
return true;
}

public static bool operator != (ST_968b59b0d969f443f958cd852a31dcb5Structure a, ST_968b59b0d969f443f958cd852a31dcb5Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_968b59b0d969f443f958cd852a31dcb5Structure)) return false;
return (this == (ST_968b59b0d969f443f958cd852a31dcb5Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssid.GetHashCode()
 ^ sstitle.GetHashCode()
 ^ sscontent.GetHashCode()
 ^ ssisread.GetHashCode()
 ^ sscreatedat.GetHashCode()
 ^ sscategoryclass.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_968b59b0d969f443f958cd852a31dcb5Structure Duplicate() {
ST_968b59b0d969f443f958cd852a31dcb5Structure t;
t.ssid = this.ssid;
t.sstitle = this.sstitle;
t.sscontent = this.sscontent;
t.ssisread = this.ssisread;
t.sscreatedat = this.sscreatedat;
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".id")) variable.Value = ssid; else variable.Optimized = true;
} else if (head == "title") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".title")) variable.Value = sstitle; else variable.Optimized = true;
} else if (head == "content") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".content")) variable.Value = sscontent; else variable.Optimized = true;
} else if (head == "isread") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".isread")) variable.Value = ssisread; else variable.Optimized = true;
} else if (head == "createdat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".createdat")) variable.Value = sscreatedat; else variable.Optimized = true;
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
if (key == Idid) {
return ssid;
}
if (key == Idtitle) {
return sstitle;
}
if (key == Idcontent) {
return sscontent;
}
if (key == Idisread) {
return ssisread;
}
if (key == Idcreatedat) {
return sscreatedat;
}
if (key == Idcategoryclass) {
return sscategoryclass;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idid.Key.AsGuid) {
return ssid;
}
if (attributeKey == Idtitle.Key.AsGuid) {
return sstitle;
}
if (attributeKey == Idcontent.Key.AsGuid) {
return sscontent;
}
if (attributeKey == Idisread.Key.AsGuid) {
return ssisread;
}
if (attributeKey == Idcreatedat.Key.AsGuid) {
return sscreatedat;
}
if (attributeKey == Idcategoryclass.Key.AsGuid) {
return sscategoryclass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssid = (long) other.AttributeGet(Idid);
sstitle = (string) other.AttributeGet(Idtitle);
sscontent = (string) other.AttributeGet(Idcontent);
ssisread = (bool) other.AttributeGet(Idisread);
sscreatedat = (DateTime) other.AttributeGet(Idcreatedat);
sscategoryclass = (string) other.AttributeGet(Idcategoryclass);
}
} // ST_968b59b0d969f443f958cd852a31dcb5Structure
/// <summary>
/// RecordList type <code>NotificationOutput2List</code> that represents a record list of
///  <code>NotificationOutput2</code>
/// </summary>
public partial class RL_02b33a244546a7f09e6ac2e1170aaea2 : GenericRecordList<ST_968b59b0d969f443f958cd852a31dcb5Structure>, IEnumerable, IEnumerator {

protected override ST_968b59b0d969f443f958cd852a31dcb5Structure GetElementDefaultValue() {
return new ST_968b59b0d969f443f958cd852a31dcb5Structure();
}

public T[] ToArray<T>(Func<ST_968b59b0d969f443f958cd852a31dcb5Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_02b33a244546a7f09e6ac2e1170aaea2 recordList, Func<ST_968b59b0d969f443f958cd852a31dcb5Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_02b33a244546a7f09e6ac2e1170aaea2(ST_968b59b0d969f443f958cd852a31dcb5Structure[] array) {
  RL_02b33a244546a7f09e6ac2e1170aaea2 result = new RL_02b33a244546a7f09e6ac2e1170aaea2();
result.InnerFromArray(array);
    return result;
}

public static RL_02b33a244546a7f09e6ac2e1170aaea2 ToList<T>(T[] array, Func <T, ST_968b59b0d969f443f958cd852a31dcb5Structure> converter) {
  RL_02b33a244546a7f09e6ac2e1170aaea2 result = new RL_02b33a244546a7f09e6ac2e1170aaea2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_02b33a244546a7f09e6ac2e1170aaea2 FromRestList<T>(RestList<T> restList, Func <T, ST_968b59b0d969f443f958cd852a31dcb5Structure> converter) {
  RL_02b33a244546a7f09e6ac2e1170aaea2 result = new RL_02b33a244546a7f09e6ac2e1170aaea2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_02b33a244546a7f09e6ac2e1170aaea2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_968b59b0d969f443f958cd852a31dcb5Structure> NewList() {
return new RL_02b33a244546a7f09e6ac2e1170aaea2();
}


} // RL_02b33a244546a7f09e6ac2e1170aaea2
}


namespace ssConectaProveedores {
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Abstractions;
public class RESTNotificationOutput2 {
[JsonProperty("id")]
public long? restid;

[JsonProperty("title")]
public string resttitle;

[JsonProperty("content")]
public string restcontent;

[JsonProperty("isread")]
public bool? restisread;

[JsonProperty("createdat")]
public DateTime? restcreatedat;

[JsonProperty("categoryclass")]
public string restcategoryclass;

public RESTNotificationOutput2() { }

public RESTNotificationOutput2(ST_968b59b0d969f443f958cd852a31dcb5Structure s) {
restid = (long?) s.ssid;
resttitle = s.sstitle == "" ? null : s.sstitle;
restcontent = s.sscontent == "" ? null : s.sscontent;
restisread = s.ssisread == false ? null : (bool?) s.ssisread;
restcreatedat = (DateTime?) Conversions.DateTimeToUniversal(s.sscreatedat);
restcategoryclass = s.sscategoryclass == "" ? null : s.sscategoryclass;
}

public static ST_968b59b0d969f443f958cd852a31dcb5Structure ToStructure(RESTNotificationOutput2 obj) { 
  ST_968b59b0d969f443f958cd852a31dcb5Structure s = new ST_968b59b0d969f443f958cd852a31dcb5Structure();
  if(obj != null) {
  s.ssid = obj.restid == null ? 0L : obj.restid.Value;
  s.sstitle = obj.resttitle == null ? "" : obj.resttitle;
  s.sscontent = obj.restcontent == null ? "" : obj.restcontent;
  s.ssisread = obj.restisread == null ? false : obj.restisread.Value;
  s.sscreatedat = obj.restcreatedat == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : Conversions.DateTimeToUniversal((DateTime)obj.restcreatedat);
  s.sscategoryclass = obj.restcategoryclass == null ? "" : obj.restcategoryclass;
  }
  return s;
}

public static RESTNotificationOutput2 FromStructure(ST_968b59b0d969f443f958cd852a31dcb5Structure s) { 
  return new RESTNotificationOutput2(s);
}

}
}
