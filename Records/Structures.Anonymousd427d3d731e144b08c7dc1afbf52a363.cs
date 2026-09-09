namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (19Mn1OExsESMfcGvv1KjYw)
///  <code>RC_d69007668fd5133aa9666ff86ada7ddc</code> that represents <code>FolioDetailInfoRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioDetailInfoRecord
public partial struct RC_d69007668fd5133aa9666ff86ada7ddc : ITypedRecord<RC_d69007668fd5133aa9666ff86ada7ddc> {
internal static readonly GlobalObjectKey IdFolioDetailInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZgeQ1tWPOhOpZm_4atp93A");

public ST_62dd5b695df6cdb1dddea5855e8718baStructure ssSTFolioDetailInfo;


public static implicit operator ST_62dd5b695df6cdb1dddea5855e8718baStructure( RC_d69007668fd5133aa9666ff86ada7ddc r) {
return r.ssSTFolioDetailInfo;
}

public static implicit operator RC_d69007668fd5133aa9666ff86ada7ddc (ST_62dd5b695df6cdb1dddea5855e8718baStructure r) {
RC_d69007668fd5133aa9666ff86ada7ddc res = new RC_d69007668fd5133aa9666ff86ada7ddc ();
res.ssSTFolioDetailInfo = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_d69007668fd5133aa9666ff86ada7ddc() {
OptimizedAttributes = null;
ssSTFolioDetailInfo = new ST_62dd5b695df6cdb1dddea5855e8718baStructure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTFolioDetailInfo.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTFolioDetailInfo.Read( r, ref index);
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
public void ReadIM(RC_d69007668fd5133aa9666ff86ada7ddc r) {
this = r;
}


public static bool operator == (RC_d69007668fd5133aa9666ff86ada7ddc a, RC_d69007668fd5133aa9666ff86ada7ddc b) {
if (a.ssSTFolioDetailInfo != b.ssSTFolioDetailInfo) return false;
return true;
}

public static bool operator != (RC_d69007668fd5133aa9666ff86ada7ddc a, RC_d69007668fd5133aa9666ff86ada7ddc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d69007668fd5133aa9666ff86ada7ddc)) return false;
return (this == (RC_d69007668fd5133aa9666ff86ada7ddc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFolioDetailInfo.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFolioDetailInfo.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFolioDetailInfo.InternalRecursiveSave();
}


public RC_d69007668fd5133aa9666ff86ada7ddc Duplicate() {
RC_d69007668fd5133aa9666ff86ada7ddc t;
t.ssSTFolioDetailInfo = (ST_62dd5b695df6cdb1dddea5855e8718baStructure)this.ssSTFolioDetailInfo.Duplicate();
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
if (head == "foliodetailinfo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioDetailInfo")) variable.Value = ssSTFolioDetailInfo; else variable.Optimized = true;
variable.SetFieldName("foliodetailinfo");
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
if (key == IdFolioDetailInfo) {
return ssSTFolioDetailInfo;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioDetailInfo.Key.AsGuid) {
return ssSTFolioDetailInfo;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFolioDetailInfo.FillFromOther((IRecord) other.AttributeGet(IdFolioDetailInfo));
}
} // RC_d69007668fd5133aa9666ff86ada7ddc
/// <summary>
/// RecordList type <code>FolioDetailInfoRecordList</code> that represents a record list of
///  <code>FolioDetailInfo</code>
/// </summary>
public partial class RL_b216f2d53411c33b32b03913162c4d0c : GenericRecordList<RC_d69007668fd5133aa9666ff86ada7ddc>, IEnumerable, IEnumerator {

protected override RC_d69007668fd5133aa9666ff86ada7ddc GetElementDefaultValue() {
return new RC_d69007668fd5133aa9666ff86ada7ddc();
}

public T[] ToArray<T>(Func<RC_d69007668fd5133aa9666ff86ada7ddc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b216f2d53411c33b32b03913162c4d0c recordList, Func<RC_d69007668fd5133aa9666ff86ada7ddc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b216f2d53411c33b32b03913162c4d0c(RC_d69007668fd5133aa9666ff86ada7ddc[] array) {
  RL_b216f2d53411c33b32b03913162c4d0c result = new RL_b216f2d53411c33b32b03913162c4d0c();
result.InnerFromArray(array);
    return result;
}

public static RL_b216f2d53411c33b32b03913162c4d0c ToList<T>(T[] array, Func <T, RC_d69007668fd5133aa9666ff86ada7ddc> converter) {
  RL_b216f2d53411c33b32b03913162c4d0c result = new RL_b216f2d53411c33b32b03913162c4d0c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b216f2d53411c33b32b03913162c4d0c FromRestList<T>(RestList<T> restList, Func <T, RC_d69007668fd5133aa9666ff86ada7ddc> converter) {
  RL_b216f2d53411c33b32b03913162c4d0c result = new RL_b216f2d53411c33b32b03913162c4d0c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b216f2d53411c33b32b03913162c4d0c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d69007668fd5133aa9666ff86ada7ddc> NewList() {
return new RL_b216f2d53411c33b32b03913162c4d0c();
}


} // RL_b216f2d53411c33b32b03913162c4d0c
}

