namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (bGGs2NdRQkyrwQgsioIJyw)
///  <code>RC_ba02c963eabdf75d57d498152c3db2fa</code> that represents <code>FolioRegionSeqRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioRegionSeqRecord
public partial struct RC_ba02c963eabdf75d57d498152c3db2fa : ITypedRecord<RC_ba02c963eabdf75d57d498152c3db2fa> {
internal static readonly GlobalObjectKey IdFolioRegionSeq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Y8kCur3qXfdX1JgVLD2y+g");

public EN_6d30d3f082837359d34a81528b515a59EntityRecord ssENFolioRegionSeq;


public static implicit operator EN_6d30d3f082837359d34a81528b515a59EntityRecord( RC_ba02c963eabdf75d57d498152c3db2fa r) {
return r.ssENFolioRegionSeq;
}

public static implicit operator RC_ba02c963eabdf75d57d498152c3db2fa (EN_6d30d3f082837359d34a81528b515a59EntityRecord r) {
RC_ba02c963eabdf75d57d498152c3db2fa res = new RC_ba02c963eabdf75d57d498152c3db2fa ();
res.ssENFolioRegionSeq = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENFolioRegionSeq.ChangedAttributes = value;
}
get {
    return ssENFolioRegionSeq.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_ba02c963eabdf75d57d498152c3db2fa() {
OptimizedAttributes = null;
ssENFolioRegionSeq = new EN_6d30d3f082837359d34a81528b515a59EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioRegionSeq.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENFolioRegionSeq.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENFolioRegionSeq.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioRegionSeq.Read( r, ref index);
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
public void ReadIM(RC_ba02c963eabdf75d57d498152c3db2fa r) {
this = r;
}


public static bool operator == (RC_ba02c963eabdf75d57d498152c3db2fa a, RC_ba02c963eabdf75d57d498152c3db2fa b) {
if (a.ssENFolioRegionSeq != b.ssENFolioRegionSeq) return false;
return true;
}

public static bool operator != (RC_ba02c963eabdf75d57d498152c3db2fa a, RC_ba02c963eabdf75d57d498152c3db2fa b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ba02c963eabdf75d57d498152c3db2fa)) return false;
return (this == (RC_ba02c963eabdf75d57d498152c3db2fa)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioRegionSeq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioRegionSeq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioRegionSeq.InternalRecursiveSave();
}


public RC_ba02c963eabdf75d57d498152c3db2fa Duplicate() {
RC_ba02c963eabdf75d57d498152c3db2fa t;
t.ssENFolioRegionSeq = (EN_6d30d3f082837359d34a81528b515a59EntityRecord)this.ssENFolioRegionSeq.Duplicate();
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
if (head == "folioregionseq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioRegionSeq")) variable.Value = ssENFolioRegionSeq; else variable.Optimized = true;
variable.SetFieldName("folioregionseq");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENFolioRegionSeq.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENFolioRegionSeq.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdFolioRegionSeq) {
return ssENFolioRegionSeq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioRegionSeq.Key.AsGuid) {
return ssENFolioRegionSeq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioRegionSeq.FillFromOther((IRecord) other.AttributeGet(IdFolioRegionSeq));
}
} // RC_ba02c963eabdf75d57d498152c3db2fa
/// <summary>
/// RecordList type <code>FolioRegionSeqRecordList</code> that represents a record list of
///  <code>FolioRegionSeq</code>
/// </summary>
public partial class RL_321dd0d04a3c06ceeabbe51d5902cdbf : GenericRecordList<RC_ba02c963eabdf75d57d498152c3db2fa>, IEnumerable, IEnumerator {

protected override RC_ba02c963eabdf75d57d498152c3db2fa GetElementDefaultValue() {
return new RC_ba02c963eabdf75d57d498152c3db2fa();
}

public T[] ToArray<T>(Func<RC_ba02c963eabdf75d57d498152c3db2fa, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_321dd0d04a3c06ceeabbe51d5902cdbf recordList, Func<RC_ba02c963eabdf75d57d498152c3db2fa, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_321dd0d04a3c06ceeabbe51d5902cdbf(RC_ba02c963eabdf75d57d498152c3db2fa[] array) {
  RL_321dd0d04a3c06ceeabbe51d5902cdbf result = new RL_321dd0d04a3c06ceeabbe51d5902cdbf();
result.InnerFromArray(array);
    return result;
}

public static RL_321dd0d04a3c06ceeabbe51d5902cdbf ToList<T>(T[] array, Func <T, RC_ba02c963eabdf75d57d498152c3db2fa> converter) {
  RL_321dd0d04a3c06ceeabbe51d5902cdbf result = new RL_321dd0d04a3c06ceeabbe51d5902cdbf();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_321dd0d04a3c06ceeabbe51d5902cdbf FromRestList<T>(RestList<T> restList, Func <T, RC_ba02c963eabdf75d57d498152c3db2fa> converter) {
  RL_321dd0d04a3c06ceeabbe51d5902cdbf result = new RL_321dd0d04a3c06ceeabbe51d5902cdbf();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_321dd0d04a3c06ceeabbe51d5902cdbf() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ba02c963eabdf75d57d498152c3db2fa> NewList() {
return new RL_321dd0d04a3c06ceeabbe51d5902cdbf();
}


} // RL_321dd0d04a3c06ceeabbe51d5902cdbf
}

