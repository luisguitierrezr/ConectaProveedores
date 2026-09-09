namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (u2+ORUFirU2gEbolTxRvbg)
///  <code>RC_42d297db5356ec5acb8465e0977849c0</code> that represents <code>ProposalLogsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ProposalLogsRecord
public partial struct RC_42d297db5356ec5acb8465e0977849c0 : ITypedRecord<RC_42d297db5356ec5acb8465e0977849c0> {
internal static readonly GlobalObjectKey IdProposalLogs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*25fSQlZTWuzLhGXgl3hJwA");

public EN_013f76cfa3062515b73935963b1697b0EntityRecord ssENProposalLogs;


public static implicit operator EN_013f76cfa3062515b73935963b1697b0EntityRecord( RC_42d297db5356ec5acb8465e0977849c0 r) {
return r.ssENProposalLogs;
}

public static implicit operator RC_42d297db5356ec5acb8465e0977849c0 (EN_013f76cfa3062515b73935963b1697b0EntityRecord r) {
RC_42d297db5356ec5acb8465e0977849c0 res = new RC_42d297db5356ec5acb8465e0977849c0 ();
res.ssENProposalLogs = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProposalLogs.ChangedAttributes = value;
}
get {
    return ssENProposalLogs.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_42d297db5356ec5acb8465e0977849c0() {
OptimizedAttributes = null;
ssENProposalLogs = new EN_013f76cfa3062515b73935963b1697b0EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposalLogs.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProposalLogs.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProposalLogs.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProposalLogs.Read( r, ref index);
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
public void ReadIM(RC_42d297db5356ec5acb8465e0977849c0 r) {
this = r;
}


public static bool operator == (RC_42d297db5356ec5acb8465e0977849c0 a, RC_42d297db5356ec5acb8465e0977849c0 b) {
if (a.ssENProposalLogs != b.ssENProposalLogs) return false;
return true;
}

public static bool operator != (RC_42d297db5356ec5acb8465e0977849c0 a, RC_42d297db5356ec5acb8465e0977849c0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_42d297db5356ec5acb8465e0977849c0)) return false;
return (this == (RC_42d297db5356ec5acb8465e0977849c0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposalLogs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposalLogs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposalLogs.InternalRecursiveSave();
}


public RC_42d297db5356ec5acb8465e0977849c0 Duplicate() {
RC_42d297db5356ec5acb8465e0977849c0 t;
t.ssENProposalLogs = (EN_013f76cfa3062515b73935963b1697b0EntityRecord)this.ssENProposalLogs.Duplicate();
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
if (head == "proposallogs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalLogs")) variable.Value = ssENProposalLogs; else variable.Optimized = true;
variable.SetFieldName("proposallogs");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProposalLogs.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProposalLogs.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProposalLogs) {
return ssENProposalLogs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalLogs.Key.AsGuid) {
return ssENProposalLogs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposalLogs.FillFromOther((IRecord) other.AttributeGet(IdProposalLogs));
}
} // RC_42d297db5356ec5acb8465e0977849c0
/// <summary>
/// RecordList type <code>ProposalLogsRecordList</code> that represents a record list of
///  <code>ProposalLogs</code>
/// </summary>
public partial class RL_4c366307482ae336e685dced00a25d87 : GenericRecordList<RC_42d297db5356ec5acb8465e0977849c0>, IEnumerable, IEnumerator {

protected override RC_42d297db5356ec5acb8465e0977849c0 GetElementDefaultValue() {
return new RC_42d297db5356ec5acb8465e0977849c0();
}

public T[] ToArray<T>(Func<RC_42d297db5356ec5acb8465e0977849c0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4c366307482ae336e685dced00a25d87 recordList, Func<RC_42d297db5356ec5acb8465e0977849c0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4c366307482ae336e685dced00a25d87(RC_42d297db5356ec5acb8465e0977849c0[] array) {
  RL_4c366307482ae336e685dced00a25d87 result = new RL_4c366307482ae336e685dced00a25d87();
result.InnerFromArray(array);
    return result;
}

public static RL_4c366307482ae336e685dced00a25d87 ToList<T>(T[] array, Func <T, RC_42d297db5356ec5acb8465e0977849c0> converter) {
  RL_4c366307482ae336e685dced00a25d87 result = new RL_4c366307482ae336e685dced00a25d87();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4c366307482ae336e685dced00a25d87 FromRestList<T>(RestList<T> restList, Func <T, RC_42d297db5356ec5acb8465e0977849c0> converter) {
  RL_4c366307482ae336e685dced00a25d87 result = new RL_4c366307482ae336e685dced00a25d87();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4c366307482ae336e685dced00a25d87() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_42d297db5356ec5acb8465e0977849c0> NewList() {
return new RL_4c366307482ae336e685dced00a25d87();
}


} // RL_4c366307482ae336e685dced00a25d87
}

