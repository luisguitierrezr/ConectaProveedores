namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (TkWsku67tEWf_Qq+Tzwqlw)
///  <code>RC_1ab3ef48680b2ecd9418ca5a547fee53</code> that represent
/// s <code>ProposalFileExtendedFile3Record</code> <p>Description: </p>
/// </summary>
// Name: ProposalFileExtendedFile3Record
public partial struct RC_1ab3ef48680b2ecd9418ca5a547fee53 : ITypedRecord<RC_1ab3ef48680b2ecd9418ca5a547fee53> {
internal static readonly GlobalObjectKey IdProposal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9MStkYpvUQ_KzEvHGNLqNQ");
internal static readonly GlobalObjectKey IdFileExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jaI+blUswivMEp9CKX5Zgg");
internal static readonly GlobalObjectKey IdFile3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2i0j5ZWGtaY9eq_MO22Efw");

public EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord ssENProposal;

public EN_dcebdd8ba305133f41b1e1804925997fEntityRecord ssENFileExtended;

public EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord ssENFile3;


public BitArray OptimizedAttributes;

public RC_1ab3ef48680b2ecd9418ca5a547fee53() {
OptimizedAttributes = null;
ssENProposal = new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
ssENFileExtended = new EN_dcebdd8ba305133f41b1e1804925997fEntityRecord();
ssENFile3 = new EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(18,false);
    all[1] = new BitArray(7,false);
    all[2] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProposal.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFileExtended.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFile3.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENProposal.OptimizedAttributes = value[0];
    ssENFileExtended.OptimizedAttributes = value[1];
    ssENFile3.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENProposal.OptimizedAttributes;
    all[1] = ssENFileExtended.OptimizedAttributes;
    all[2] = ssENFile3.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProposal.Read( r, ref index);
ssENFileExtended.Read( r, ref index);
ssENFile3.Read( r, ref index);
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
public void ReadIM(RC_1ab3ef48680b2ecd9418ca5a547fee53 r) {
this = r;
}


public static bool operator == (RC_1ab3ef48680b2ecd9418ca5a547fee53 a, RC_1ab3ef48680b2ecd9418ca5a547fee53 b) {
if (a.ssENProposal != b.ssENProposal) return false;
if (a.ssENFileExtended != b.ssENFileExtended) return false;
if (a.ssENFile3 != b.ssENFile3) return false;
return true;
}

public static bool operator != (RC_1ab3ef48680b2ecd9418ca5a547fee53 a, RC_1ab3ef48680b2ecd9418ca5a547fee53 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1ab3ef48680b2ecd9418ca5a547fee53)) return false;
return (this == (RC_1ab3ef48680b2ecd9418ca5a547fee53)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProposal.GetHashCode()
 ^ ssENFileExtended.GetHashCode()
 ^ ssENFile3.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProposal.RecursiveReset();
ssENFileExtended.RecursiveReset();
ssENFile3.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProposal.InternalRecursiveSave();
ssENFileExtended.InternalRecursiveSave();
ssENFile3.InternalRecursiveSave();
}


public RC_1ab3ef48680b2ecd9418ca5a547fee53 Duplicate() {
RC_1ab3ef48680b2ecd9418ca5a547fee53 t;
t.ssENProposal = (EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord)this.ssENProposal.Duplicate();
t.ssENFileExtended = (EN_dcebdd8ba305133f41b1e1804925997fEntityRecord)this.ssENFileExtended.Duplicate();
t.ssENFile3 = (EN_1d38c6a5bdfe9befe9c6396896ed360eEntityRecord)this.ssENFile3.Duplicate();
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
if (head == "proposal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Proposal")) variable.Value = ssENProposal; else variable.Optimized = true;
variable.SetFieldName("proposal");
} else if (head == "fileextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FileExtended")) variable.Value = ssENFileExtended; else variable.Optimized = true;
variable.SetFieldName("fileextended");
} else if (head == "file3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".File3")) variable.Value = ssENFile3; else variable.Optimized = true;
variable.SetFieldName("file3");
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
if (key == IdProposal) {
return ssENProposal;
}
if (key == IdFileExtended) {
return ssENFileExtended;
}
if (key == IdFile3) {
return ssENFile3;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposal.Key.AsGuid) {
return ssENProposal;
}
if (attributeKey == IdFileExtended.Key.AsGuid) {
return ssENFileExtended;
}
if (attributeKey == IdFile3.Key.AsGuid) {
return ssENFile3;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProposal.FillFromOther((IRecord) other.AttributeGet(IdProposal));
ssENFileExtended.FillFromOther((IRecord) other.AttributeGet(IdFileExtended));
ssENFile3.FillFromOther((IRecord) other.AttributeGet(IdFile3));
}
} // RC_1ab3ef48680b2ecd9418ca5a547fee53
/// <summary>
/// RecordList type <code>ProposalFileExtendedFile3RecordList</code> that represents a record list of
///  <code>Proposal, FileExtended, File3</code>
/// </summary>
public partial class RL_d5919f61ef80d8f84623e1797c2e85cd : GenericRecordList<RC_1ab3ef48680b2ecd9418ca5a547fee53>, IEnumerable, IEnumerator {

protected override RC_1ab3ef48680b2ecd9418ca5a547fee53 GetElementDefaultValue() {
return new RC_1ab3ef48680b2ecd9418ca5a547fee53();
}

public T[] ToArray<T>(Func<RC_1ab3ef48680b2ecd9418ca5a547fee53, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d5919f61ef80d8f84623e1797c2e85cd recordList, Func<RC_1ab3ef48680b2ecd9418ca5a547fee53, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d5919f61ef80d8f84623e1797c2e85cd(RC_1ab3ef48680b2ecd9418ca5a547fee53[] array) {
  RL_d5919f61ef80d8f84623e1797c2e85cd result = new RL_d5919f61ef80d8f84623e1797c2e85cd();
result.InnerFromArray(array);
    return result;
}

public static RL_d5919f61ef80d8f84623e1797c2e85cd ToList<T>(T[] array, Func <T, RC_1ab3ef48680b2ecd9418ca5a547fee53> converter) {
  RL_d5919f61ef80d8f84623e1797c2e85cd result = new RL_d5919f61ef80d8f84623e1797c2e85cd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d5919f61ef80d8f84623e1797c2e85cd FromRestList<T>(RestList<T> restList, Func <T, RC_1ab3ef48680b2ecd9418ca5a547fee53> converter) {
  RL_d5919f61ef80d8f84623e1797c2e85cd result = new RL_d5919f61ef80d8f84623e1797c2e85cd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d5919f61ef80d8f84623e1797c2e85cd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(18,false);
def[1] = new BitArray(7,false);
def[2] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1ab3ef48680b2ecd9418ca5a547fee53> NewList() {
return new RL_d5919f61ef80d8f84623e1797c2e85cd();
}


} // RL_d5919f61ef80d8f84623e1797c2e85cd
}

