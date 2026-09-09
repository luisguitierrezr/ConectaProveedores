namespace ssConectaProveedores {
/// <summary>
/// [Structure] ExportDisplayedProposalsStruct (s1WLfKI++068CzJN+LxYtA)
///  <code>ST_1c87550db65690e27fa2476539c804c3Structure</code> that represent
/// s <code>ExportDisplayedProposalsStruct</code> <p>Description: Export Displayed Proposals
///  Struct.</p>
/// </summary>
// Name: ExportDisplayedProposalsStruct
public partial struct ST_1c87550db65690e27fa2476539c804c3Structure : ITypedRecord<ST_1c87550db65690e27fa2476539c804c3Structure> {
internal static readonly GlobalObjectKey IdProposalName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gLXWU2P02U+yU7C7MwVZyw");
internal static readonly GlobalObjectKey IdProposalType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*qHIKd6_JvE6N3eBK2vA5sw");
internal static readonly GlobalObjectKey IdUploadedDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KJRWicmreku39rga0BZyLw");
internal static readonly GlobalObjectKey IdUploadedby = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4UQAbDbu0UW3Lvh8gn8mNg");
internal static readonly GlobalObjectKey IdPaymentDate = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*reRbZfhFCEOySnaIExdiQg");
internal static readonly GlobalObjectKey IdBank = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sl0fHI96KEaINkJYU03puQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*G4oejujKIUKw2fC6Ic7n8A");
internal static readonly GlobalObjectKey IdAmountML = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*A9emI9kh20uPJVlLDcIwow");
internal static readonly GlobalObjectKey IdAmountMD = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*O4zW4L3QkUqGAR6JNbj7tA");
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1d1PY_aGKUOD1BN0Xs8AAQ");
internal static readonly GlobalObjectKey IdStatus = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*4AfCrW5qVkKUeqJoNuuDGQ");
internal static readonly GlobalObjectKey IdUploadType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ClDKHE17Xkyz_1MwcrMxDA");

public string ssProposalName;

public string ssProposalType;

public DateTime ssUploadedDate;

public string ssUploadedby;

public DateTime ssPaymentDate;

public string ssBank;

public string ssRegion;

public decimal ssAmountML;

public decimal ssAmountMD;

public string ssCurrency;

public string ssStatus;

public string ssUploadType;


public BitArray OptimizedAttributes;

public ST_1c87550db65690e27fa2476539c804c3Structure() {
OptimizedAttributes = null;
ssProposalName = "";
ssProposalType = "";
ssUploadedDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssUploadedby = "";
ssPaymentDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
ssBank = "";
ssRegion = "";
ssAmountML = 0.0M;
ssAmountMD = 0.0M;
ssCurrency = "";
ssStatus = "";
ssUploadType = "";
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
ssProposalName = r.ReadText(index++, "ExportDisplayedProposalsStruct.ProposalName", "");
ssProposalType = r.ReadText(index++, "ExportDisplayedProposalsStruct.ProposalType", "");
ssUploadedDate = r.ReadDate(index++, "ExportDisplayedProposalsStruct.UploadedDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUploadedby = r.ReadText(index++, "ExportDisplayedProposalsStruct.Uploadedby", "");
ssPaymentDate = r.ReadDate(index++, "ExportDisplayedProposalsStruct.PaymentDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssBank = r.ReadText(index++, "ExportDisplayedProposalsStruct.Bank", "");
ssRegion = r.ReadText(index++, "ExportDisplayedProposalsStruct.Region", "");
ssAmountML = r.ReadDecimal(index++, "ExportDisplayedProposalsStruct.AmountML", 0.0M);
ssAmountMD = r.ReadDecimal(index++, "ExportDisplayedProposalsStruct.AmountMD", 0.0M);
ssCurrency = r.ReadText(index++, "ExportDisplayedProposalsStruct.Currency", "");
ssStatus = r.ReadText(index++, "ExportDisplayedProposalsStruct.Status", "");
ssUploadType = r.ReadText(index++, "ExportDisplayedProposalsStruct.UploadType", "");
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
public void ReadIM(ST_1c87550db65690e27fa2476539c804c3Structure r) {
this = r;
}


public static bool operator == (ST_1c87550db65690e27fa2476539c804c3Structure a, ST_1c87550db65690e27fa2476539c804c3Structure b) {
if (a.ssProposalName != b.ssProposalName) return false;
if (a.ssProposalType != b.ssProposalType) return false;
if (a.ssUploadedDate != b.ssUploadedDate) return false;
if (a.ssUploadedby != b.ssUploadedby) return false;
if (a.ssPaymentDate != b.ssPaymentDate) return false;
if (a.ssBank != b.ssBank) return false;
if (a.ssRegion != b.ssRegion) return false;
if (a.ssAmountML != b.ssAmountML) return false;
if (a.ssAmountMD != b.ssAmountMD) return false;
if (a.ssCurrency != b.ssCurrency) return false;
if (a.ssStatus != b.ssStatus) return false;
if (a.ssUploadType != b.ssUploadType) return false;
return true;
}

public static bool operator != (ST_1c87550db65690e27fa2476539c804c3Structure a, ST_1c87550db65690e27fa2476539c804c3Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1c87550db65690e27fa2476539c804c3Structure)) return false;
return (this == (ST_1c87550db65690e27fa2476539c804c3Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssProposalName.GetHashCode()
 ^ ssProposalType.GetHashCode()
 ^ ssUploadedDate.GetHashCode()
 ^ ssUploadedby.GetHashCode()
 ^ ssPaymentDate.GetHashCode()
 ^ ssBank.GetHashCode()
 ^ ssRegion.GetHashCode()
 ^ ssAmountML.GetHashCode()
 ^ ssAmountMD.GetHashCode()
 ^ ssCurrency.GetHashCode()
 ^ ssStatus.GetHashCode()
 ^ ssUploadType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_1c87550db65690e27fa2476539c804c3Structure Duplicate() {
ST_1c87550db65690e27fa2476539c804c3Structure t;
t.ssProposalName = this.ssProposalName;
t.ssProposalType = this.ssProposalType;
t.ssUploadedDate = this.ssUploadedDate;
t.ssUploadedby = this.ssUploadedby;
t.ssPaymentDate = this.ssPaymentDate;
t.ssBank = this.ssBank;
t.ssRegion = this.ssRegion;
t.ssAmountML = this.ssAmountML;
t.ssAmountMD = this.ssAmountMD;
t.ssCurrency = this.ssCurrency;
t.ssStatus = this.ssStatus;
t.ssUploadType = this.ssUploadType;
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
if (head == "proposalname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalName")) variable.Value = ssProposalName; else variable.Optimized = true;
} else if (head == "proposaltype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalType")) variable.Value = ssProposalType; else variable.Optimized = true;
} else if (head == "uploadeddate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UploadedDate")) variable.Value = ssUploadedDate; else variable.Optimized = true;
} else if (head == "uploadedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Uploadedby")) variable.Value = ssUploadedby; else variable.Optimized = true;
} else if (head == "paymentdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentDate")) variable.Value = ssPaymentDate; else variable.Optimized = true;
} else if (head == "bank") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Bank")) variable.Value = ssBank; else variable.Optimized = true;
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssRegion; else variable.Optimized = true;
} else if (head == "amountml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AmountML")) variable.Value = ssAmountML; else variable.Optimized = true;
} else if (head == "amountmd") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AmountMD")) variable.Value = ssAmountMD; else variable.Optimized = true;
} else if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssCurrency; else variable.Optimized = true;
} else if (head == "status") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Status")) variable.Value = ssStatus; else variable.Optimized = true;
} else if (head == "uploadtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UploadType")) variable.Value = ssUploadType; else variable.Optimized = true;
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
if (key == IdProposalName) {
return ssProposalName;
}
if (key == IdProposalType) {
return ssProposalType;
}
if (key == IdUploadedDate) {
return ssUploadedDate;
}
if (key == IdUploadedby) {
return ssUploadedby;
}
if (key == IdPaymentDate) {
return ssPaymentDate;
}
if (key == IdBank) {
return ssBank;
}
if (key == IdRegion) {
return ssRegion;
}
if (key == IdAmountML) {
return ssAmountML;
}
if (key == IdAmountMD) {
return ssAmountMD;
}
if (key == IdCurrency) {
return ssCurrency;
}
if (key == IdStatus) {
return ssStatus;
}
if (key == IdUploadType) {
return ssUploadType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProposalName.Key.AsGuid) {
return ssProposalName;
}
if (attributeKey == IdProposalType.Key.AsGuid) {
return ssProposalType;
}
if (attributeKey == IdUploadedDate.Key.AsGuid) {
return ssUploadedDate;
}
if (attributeKey == IdUploadedby.Key.AsGuid) {
return ssUploadedby;
}
if (attributeKey == IdPaymentDate.Key.AsGuid) {
return ssPaymentDate;
}
if (attributeKey == IdBank.Key.AsGuid) {
return ssBank;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssRegion;
}
if (attributeKey == IdAmountML.Key.AsGuid) {
return ssAmountML;
}
if (attributeKey == IdAmountMD.Key.AsGuid) {
return ssAmountMD;
}
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssCurrency;
}
if (attributeKey == IdStatus.Key.AsGuid) {
return ssStatus;
}
if (attributeKey == IdUploadType.Key.AsGuid) {
return ssUploadType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssProposalName = (string) other.AttributeGet(IdProposalName);
ssProposalType = (string) other.AttributeGet(IdProposalType);
ssUploadedDate = (DateTime) other.AttributeGet(IdUploadedDate);
ssUploadedby = (string) other.AttributeGet(IdUploadedby);
ssPaymentDate = (DateTime) other.AttributeGet(IdPaymentDate);
ssBank = (string) other.AttributeGet(IdBank);
ssRegion = (string) other.AttributeGet(IdRegion);
ssAmountML = (decimal) other.AttributeGet(IdAmountML);
ssAmountMD = (decimal) other.AttributeGet(IdAmountMD);
ssCurrency = (string) other.AttributeGet(IdCurrency);
ssStatus = (string) other.AttributeGet(IdStatus);
ssUploadType = (string) other.AttributeGet(IdUploadType);
}
} // ST_1c87550db65690e27fa2476539c804c3Structure
/// <summary>
/// RecordList type <code>ExportDisplayedProposalsStructList</code> that represents a record list of
///  <code>ExportDisplayedProposalsStruct</code>
/// </summary>
public partial class RL_a47850dd2118e9d03f96b793e5fcd15c : GenericRecordList<ST_1c87550db65690e27fa2476539c804c3Structure>, IEnumerable, IEnumerator {

protected override ST_1c87550db65690e27fa2476539c804c3Structure GetElementDefaultValue() {
return new ST_1c87550db65690e27fa2476539c804c3Structure();
}

public T[] ToArray<T>(Func<ST_1c87550db65690e27fa2476539c804c3Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a47850dd2118e9d03f96b793e5fcd15c recordList, Func<ST_1c87550db65690e27fa2476539c804c3Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a47850dd2118e9d03f96b793e5fcd15c(ST_1c87550db65690e27fa2476539c804c3Structure[] array) {
  RL_a47850dd2118e9d03f96b793e5fcd15c result = new RL_a47850dd2118e9d03f96b793e5fcd15c();
result.InnerFromArray(array);
    return result;
}

public static RL_a47850dd2118e9d03f96b793e5fcd15c ToList<T>(T[] array, Func <T, ST_1c87550db65690e27fa2476539c804c3Structure> converter) {
  RL_a47850dd2118e9d03f96b793e5fcd15c result = new RL_a47850dd2118e9d03f96b793e5fcd15c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a47850dd2118e9d03f96b793e5fcd15c FromRestList<T>(RestList<T> restList, Func <T, ST_1c87550db65690e27fa2476539c804c3Structure> converter) {
  RL_a47850dd2118e9d03f96b793e5fcd15c result = new RL_a47850dd2118e9d03f96b793e5fcd15c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a47850dd2118e9d03f96b793e5fcd15c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1c87550db65690e27fa2476539c804c3Structure> NewList() {
return new RL_a47850dd2118e9d03f96b793e5fcd15c();
}


} // RL_a47850dd2118e9d03f96b793e5fcd15c
}

