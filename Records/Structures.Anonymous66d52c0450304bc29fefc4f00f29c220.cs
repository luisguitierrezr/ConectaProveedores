namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (BCzVZjBQwkuf78TwDynCIA)
///  <code>RC_1cb14075fc17c6595e88321dd320acf3</code> that represent
/// s <code>ExportDisplayedProposalsStructRecord</code> <p>Description: </p>
/// </summary>
// Name: ExportDisplayedProposalsStructRecord
public partial struct RC_1cb14075fc17c6595e88321dd320acf3 : ITypedRecord<RC_1cb14075fc17c6595e88321dd320acf3> {
internal static readonly GlobalObjectKey IdExportDisplayedProposalsStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dUCxHBf8WcZeiDId0yCs8w");

public ST_1c87550db65690e27fa2476539c804c3Structure ssSTExportDisplayedProposalsStruct;


public static implicit operator ST_1c87550db65690e27fa2476539c804c3Structure( RC_1cb14075fc17c6595e88321dd320acf3 r) {
return r.ssSTExportDisplayedProposalsStruct;
}

public static implicit operator RC_1cb14075fc17c6595e88321dd320acf3 (ST_1c87550db65690e27fa2476539c804c3Structure r) {
RC_1cb14075fc17c6595e88321dd320acf3 res = new RC_1cb14075fc17c6595e88321dd320acf3 ();
res.ssSTExportDisplayedProposalsStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_1cb14075fc17c6595e88321dd320acf3() {
OptimizedAttributes = null;
ssSTExportDisplayedProposalsStruct = new ST_1c87550db65690e27fa2476539c804c3Structure();
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
    ssSTExportDisplayedProposalsStruct.OptimizedAttributes = value[0];
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
ssSTExportDisplayedProposalsStruct.Read( r, ref index);
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
public void ReadIM(RC_1cb14075fc17c6595e88321dd320acf3 r) {
this = r;
}


public static bool operator == (RC_1cb14075fc17c6595e88321dd320acf3 a, RC_1cb14075fc17c6595e88321dd320acf3 b) {
if (a.ssSTExportDisplayedProposalsStruct != b.ssSTExportDisplayedProposalsStruct) return false;
return true;
}

public static bool operator != (RC_1cb14075fc17c6595e88321dd320acf3 a, RC_1cb14075fc17c6595e88321dd320acf3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1cb14075fc17c6595e88321dd320acf3)) return false;
return (this == (RC_1cb14075fc17c6595e88321dd320acf3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTExportDisplayedProposalsStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTExportDisplayedProposalsStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTExportDisplayedProposalsStruct.InternalRecursiveSave();
}


public RC_1cb14075fc17c6595e88321dd320acf3 Duplicate() {
RC_1cb14075fc17c6595e88321dd320acf3 t;
t.ssSTExportDisplayedProposalsStruct = (ST_1c87550db65690e27fa2476539c804c3Structure)this.ssSTExportDisplayedProposalsStruct.Duplicate();
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
if (head == "exportdisplayedproposalsstruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExportDisplayedProposalsStruct")) variable.Value = ssSTExportDisplayedProposalsStruct; else variable.Optimized = true;
variable.SetFieldName("exportdisplayedproposalsstruct");
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
if (key == IdExportDisplayedProposalsStruct) {
return ssSTExportDisplayedProposalsStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdExportDisplayedProposalsStruct.Key.AsGuid) {
return ssSTExportDisplayedProposalsStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTExportDisplayedProposalsStruct.FillFromOther((IRecord) other.AttributeGet(IdExportDisplayedProposalsStruct));
}
} // RC_1cb14075fc17c6595e88321dd320acf3
/// <summary>
/// RecordList type <code>ExportDisplayedProposalsStructRecordList</code> that represents a record list
///  of <code>ExportDisplayedProposalsStruct</code>
/// </summary>
public partial class RL_9bdbb2510ba9631c463489d3cd2e112b : GenericRecordList<RC_1cb14075fc17c6595e88321dd320acf3>, IEnumerable, IEnumerator {

protected override RC_1cb14075fc17c6595e88321dd320acf3 GetElementDefaultValue() {
return new RC_1cb14075fc17c6595e88321dd320acf3();
}

public T[] ToArray<T>(Func<RC_1cb14075fc17c6595e88321dd320acf3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9bdbb2510ba9631c463489d3cd2e112b recordList, Func<RC_1cb14075fc17c6595e88321dd320acf3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9bdbb2510ba9631c463489d3cd2e112b(RC_1cb14075fc17c6595e88321dd320acf3[] array) {
  RL_9bdbb2510ba9631c463489d3cd2e112b result = new RL_9bdbb2510ba9631c463489d3cd2e112b();
result.InnerFromArray(array);
    return result;
}

public static RL_9bdbb2510ba9631c463489d3cd2e112b ToList<T>(T[] array, Func <T, RC_1cb14075fc17c6595e88321dd320acf3> converter) {
  RL_9bdbb2510ba9631c463489d3cd2e112b result = new RL_9bdbb2510ba9631c463489d3cd2e112b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9bdbb2510ba9631c463489d3cd2e112b FromRestList<T>(RestList<T> restList, Func <T, RC_1cb14075fc17c6595e88321dd320acf3> converter) {
  RL_9bdbb2510ba9631c463489d3cd2e112b result = new RL_9bdbb2510ba9631c463489d3cd2e112b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9bdbb2510ba9631c463489d3cd2e112b() : base() {
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
protected override OSList<RC_1cb14075fc17c6595e88321dd320acf3> NewList() {
return new RL_9bdbb2510ba9631c463489d3cd2e112b();
}


} // RL_9bdbb2510ba9631c463489d3cd2e112b
}

