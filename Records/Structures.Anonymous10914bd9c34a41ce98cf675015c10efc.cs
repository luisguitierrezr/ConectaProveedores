namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (2UuREErDzkGYz2dQFcEO_A)
///  <code>RC_47bfaf4bccb1bd03e97cb30148a93f4e</code> that represent
/// s <code>CommissionsAndLeasesFileStructRecord</code> <p>Description: </p>
/// </summary>
// Name: CommissionsAndLeasesFileStructRecord
public partial struct RC_47bfaf4bccb1bd03e97cb30148a93f4e : ITypedRecord<RC_47bfaf4bccb1bd03e97cb30148a93f4e> {
internal static readonly GlobalObjectKey IdCommissionsAndLeasesFileStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S6+_R7HMA73pfLMBSKk_Tg");

public ST_0a2958ff44247d7464fd88ba7a80597cStructure ssSTCommissionsAndLeasesFileStruct;


public static implicit operator ST_0a2958ff44247d7464fd88ba7a80597cStructure( RC_47bfaf4bccb1bd03e97cb30148a93f4e r) {
return r.ssSTCommissionsAndLeasesFileStruct;
}

public static implicit operator RC_47bfaf4bccb1bd03e97cb30148a93f4e (ST_0a2958ff44247d7464fd88ba7a80597cStructure r) {
RC_47bfaf4bccb1bd03e97cb30148a93f4e res = new RC_47bfaf4bccb1bd03e97cb30148a93f4e ();
res.ssSTCommissionsAndLeasesFileStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_47bfaf4bccb1bd03e97cb30148a93f4e() {
OptimizedAttributes = null;
ssSTCommissionsAndLeasesFileStruct = new ST_0a2958ff44247d7464fd88ba7a80597cStructure();
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
    ssSTCommissionsAndLeasesFileStruct.OptimizedAttributes = value[0];
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
ssSTCommissionsAndLeasesFileStruct.Read( r, ref index);
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
public void ReadIM(RC_47bfaf4bccb1bd03e97cb30148a93f4e r) {
this = r;
}


public static bool operator == (RC_47bfaf4bccb1bd03e97cb30148a93f4e a, RC_47bfaf4bccb1bd03e97cb30148a93f4e b) {
if (a.ssSTCommissionsAndLeasesFileStruct != b.ssSTCommissionsAndLeasesFileStruct) return false;
return true;
}

public static bool operator != (RC_47bfaf4bccb1bd03e97cb30148a93f4e a, RC_47bfaf4bccb1bd03e97cb30148a93f4e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_47bfaf4bccb1bd03e97cb30148a93f4e)) return false;
return (this == (RC_47bfaf4bccb1bd03e97cb30148a93f4e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCommissionsAndLeasesFileStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCommissionsAndLeasesFileStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCommissionsAndLeasesFileStruct.InternalRecursiveSave();
}


public RC_47bfaf4bccb1bd03e97cb30148a93f4e Duplicate() {
RC_47bfaf4bccb1bd03e97cb30148a93f4e t;
t.ssSTCommissionsAndLeasesFileStruct = (ST_0a2958ff44247d7464fd88ba7a80597cStructure)this.ssSTCommissionsAndLeasesFileStruct.Duplicate();
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
if (head == "commissionsandleasesfilestruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CommissionsAndLeasesFileStruct")) variable.Value = ssSTCommissionsAndLeasesFileStruct; else variable.Optimized = true;
variable.SetFieldName("commissionsandleasesfilestruct");
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
if (key == IdCommissionsAndLeasesFileStruct) {
return ssSTCommissionsAndLeasesFileStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCommissionsAndLeasesFileStruct.Key.AsGuid) {
return ssSTCommissionsAndLeasesFileStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCommissionsAndLeasesFileStruct.FillFromOther((IRecord) other.AttributeGet(IdCommissionsAndLeasesFileStruct));
}
} // RC_47bfaf4bccb1bd03e97cb30148a93f4e
/// <summary>
/// RecordList type <code>CommissionsAndLeasesFileStructRecordList</code> that represents a record list
///  of <code>CommissionsAndLeasesFileStruct</code>
/// </summary>
public partial class RL_82cb75d019380779df8a0b07571373a2 : GenericRecordList<RC_47bfaf4bccb1bd03e97cb30148a93f4e>, IEnumerable, IEnumerator {

protected override RC_47bfaf4bccb1bd03e97cb30148a93f4e GetElementDefaultValue() {
return new RC_47bfaf4bccb1bd03e97cb30148a93f4e();
}

public T[] ToArray<T>(Func<RC_47bfaf4bccb1bd03e97cb30148a93f4e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_82cb75d019380779df8a0b07571373a2 recordList, Func<RC_47bfaf4bccb1bd03e97cb30148a93f4e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_82cb75d019380779df8a0b07571373a2(RC_47bfaf4bccb1bd03e97cb30148a93f4e[] array) {
  RL_82cb75d019380779df8a0b07571373a2 result = new RL_82cb75d019380779df8a0b07571373a2();
result.InnerFromArray(array);
    return result;
}

public static RL_82cb75d019380779df8a0b07571373a2 ToList<T>(T[] array, Func <T, RC_47bfaf4bccb1bd03e97cb30148a93f4e> converter) {
  RL_82cb75d019380779df8a0b07571373a2 result = new RL_82cb75d019380779df8a0b07571373a2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_82cb75d019380779df8a0b07571373a2 FromRestList<T>(RestList<T> restList, Func <T, RC_47bfaf4bccb1bd03e97cb30148a93f4e> converter) {
  RL_82cb75d019380779df8a0b07571373a2 result = new RL_82cb75d019380779df8a0b07571373a2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_82cb75d019380779df8a0b07571373a2() : base() {
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
protected override OSList<RC_47bfaf4bccb1bd03e97cb30148a93f4e> NewList() {
return new RL_82cb75d019380779df8a0b07571373a2();
}


} // RL_82cb75d019380779df8a0b07571373a2
}

