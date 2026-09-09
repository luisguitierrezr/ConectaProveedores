namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (NpRfgYNAvEuLY5dKv7ryVQ)
///  <code>RC_6acf2565530fd56605391a00cf9e3b1e</code> that represents <code>FolioAccDataRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioAccDataRecord
public partial struct RC_6acf2565530fd56605391a00cf9e3b1e : ITypedRecord<RC_6acf2565530fd56605391a00cf9e3b1e> {
internal static readonly GlobalObjectKey IdFolioAccData = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZSXPag9TZtUFORoAz547Hg");

public ST_6dc39d329f4b959722daa75bc2f62c1fStructure ssSTFolioAccData;


public static implicit operator ST_6dc39d329f4b959722daa75bc2f62c1fStructure( RC_6acf2565530fd56605391a00cf9e3b1e r) {
return r.ssSTFolioAccData;
}

public static implicit operator RC_6acf2565530fd56605391a00cf9e3b1e (ST_6dc39d329f4b959722daa75bc2f62c1fStructure r) {
RC_6acf2565530fd56605391a00cf9e3b1e res = new RC_6acf2565530fd56605391a00cf9e3b1e ();
res.ssSTFolioAccData = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6acf2565530fd56605391a00cf9e3b1e() {
OptimizedAttributes = null;
ssSTFolioAccData = new ST_6dc39d329f4b959722daa75bc2f62c1fStructure();
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
    ssSTFolioAccData.OptimizedAttributes = value[0];
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
ssSTFolioAccData.Read( r, ref index);
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
public void ReadIM(RC_6acf2565530fd56605391a00cf9e3b1e r) {
this = r;
}


public static bool operator == (RC_6acf2565530fd56605391a00cf9e3b1e a, RC_6acf2565530fd56605391a00cf9e3b1e b) {
if (a.ssSTFolioAccData != b.ssSTFolioAccData) return false;
return true;
}

public static bool operator != (RC_6acf2565530fd56605391a00cf9e3b1e a, RC_6acf2565530fd56605391a00cf9e3b1e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6acf2565530fd56605391a00cf9e3b1e)) return false;
return (this == (RC_6acf2565530fd56605391a00cf9e3b1e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTFolioAccData.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTFolioAccData.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTFolioAccData.InternalRecursiveSave();
}


public RC_6acf2565530fd56605391a00cf9e3b1e Duplicate() {
RC_6acf2565530fd56605391a00cf9e3b1e t;
t.ssSTFolioAccData = (ST_6dc39d329f4b959722daa75bc2f62c1fStructure)this.ssSTFolioAccData.Duplicate();
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
if (head == "folioaccdata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioAccData")) variable.Value = ssSTFolioAccData; else variable.Optimized = true;
variable.SetFieldName("folioaccdata");
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
if (key == IdFolioAccData) {
return ssSTFolioAccData;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioAccData.Key.AsGuid) {
return ssSTFolioAccData;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTFolioAccData.FillFromOther((IRecord) other.AttributeGet(IdFolioAccData));
}
} // RC_6acf2565530fd56605391a00cf9e3b1e
/// <summary>
/// RecordList type <code>FolioAccDataRecordList</code> that represents a record list of
///  <code>FolioAccData</code>
/// </summary>
public partial class RL_233904d8d891ea5273dea572387acca8 : GenericRecordList<RC_6acf2565530fd56605391a00cf9e3b1e>, IEnumerable, IEnumerator {

protected override RC_6acf2565530fd56605391a00cf9e3b1e GetElementDefaultValue() {
return new RC_6acf2565530fd56605391a00cf9e3b1e();
}

public T[] ToArray<T>(Func<RC_6acf2565530fd56605391a00cf9e3b1e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_233904d8d891ea5273dea572387acca8 recordList, Func<RC_6acf2565530fd56605391a00cf9e3b1e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_233904d8d891ea5273dea572387acca8(RC_6acf2565530fd56605391a00cf9e3b1e[] array) {
  RL_233904d8d891ea5273dea572387acca8 result = new RL_233904d8d891ea5273dea572387acca8();
result.InnerFromArray(array);
    return result;
}

public static RL_233904d8d891ea5273dea572387acca8 ToList<T>(T[] array, Func <T, RC_6acf2565530fd56605391a00cf9e3b1e> converter) {
  RL_233904d8d891ea5273dea572387acca8 result = new RL_233904d8d891ea5273dea572387acca8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_233904d8d891ea5273dea572387acca8 FromRestList<T>(RestList<T> restList, Func <T, RC_6acf2565530fd56605391a00cf9e3b1e> converter) {
  RL_233904d8d891ea5273dea572387acca8 result = new RL_233904d8d891ea5273dea572387acca8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_233904d8d891ea5273dea572387acca8() : base() {
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
protected override OSList<RC_6acf2565530fd56605391a00cf9e3b1e> NewList() {
return new RL_233904d8d891ea5273dea572387acca8();
}


} // RL_233904d8d891ea5273dea572387acca8
}

